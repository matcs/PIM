function buy() {
    confirmPayment();
}

function convertValue() {
    const inputValues = getValueInput();
    const cryptoCurrency = getCryptoCurrencyType();
    const covertedValue = (inputValues.amount / cryptoCurrency);
    document.getElementById('convertedValue').value = covertedValue;

    return covertedValue;
}

function getValueInput() {
    const cryptoCurrency = document.getElementById('cryptoCurrency').value;
    const amount = document.getElementById('amount').value;

    const values = { cryptoCurrency: cryptoCurrency, amount: amount };

    return values;
}

function getCryptoCurrencyType() {
    const cryptoCurrencyInputSelected = getValueInput().cryptoCurrency;

    let cryptoCurrencyValue = 0;

    switch (cryptoCurrencyInputSelected) {
        case 'Bitcoin':
            cryptoCurrencyValue = 78879;
            break;
        case 'Ethereum':
            cryptoCurrencyValue = 2227.80;
            break;
        case 'BasicAttentionToken':
            cryptoCurrencyValue = 1.09;
            break;
        case 'Ripple':
            cryptoCurrencyValue = 1.38;
            break;
        case 'Maker':
            cryptoCurrencyValue = 3084.11;
            break;
    }

    return cryptoCurrencyValue;
}

function confirmPayment() {
    const cryptoCurrencyInputs = getValueInput();
    const cryptoCurrency = cryptoCurrencyInputs.cryptoCurrency;
    const amount = cryptoCurrencyInputs.amount;
    const total = convertValue();
    const str = `Moeda: ${cryptoCurrency} - Investimento: ${amount} - Total: ${total}`;

    const swalWithBootstrapButtons = Swal.mixin({
        customClass: {
            confirmButton: 'btn btn-success',
            cancelButton: 'btn btn-danger'
        },
        buttonsStyling: false
    })

    swalWithBootstrapButtons.fire({
        title: 'Tem certeza que deseja finalizar a compra?',
        text: str,
        icon: 'warning',
        showCancelButton: true,
        confirmButtonText: 'Finalizar compra',
        cancelButtonText: 'Cancelar compra',
        reverseButtons: true
    }).then((result) => {
        if (result.isConfirmed) {
            swalWithBootstrapButtons.fire(
                'Compra concluida!',
                'Obrigado por comprar conosnco',
                'success'
            );
            postInWallet();
            createPaymentRecipt();
        } else if (
            result.dismiss === Swal.DismissReason.cancel
        ) {
            swalWithBootstrapButtons.fire(
                'Cancelada',
                'Sua compra foi cancelada!',
                'error'
            )
        }
    });
}

async function postInWallet() {
    const user = await getUserInfo();
    const customerId = user[0].custumerId;
    const walletId = await getCustomerWallet();
    const amount = convertValue() + walletId.walletBalance;
    const Wallet = { WalletId: walletId.walletId, WalletBalance: amount, CustomerId: customerId };

    const response = await fetch('https://localhost:44343/api/Wallets/' + walletId.walletId, {
        method: 'put',
        headers: headersConstruct(),
        body: JSON.stringify(Wallet)
    });

}

async function getCustomerWallet() {
    const id = getUserId();
    const response = await fetch('https://localhost:44343/api/Wallets/' + id, {
        method: 'get',
        headers: headersConstruct(),
    }).then(response => response.json());

    return response[0];
}

async function createPaymentRecipt() {
    const user = await getUserInfo();
    
    const customerId = user[0].custumerId;

    const data = getDateNow();
    const description = generateDescription();
    const amount = Number.parseFloat(getValueInput().amount);

    const PaymentReceipt = { TransactionDate: data, Amount: amount, Description: description, CustomerId: customerId };
    
    const response = await fetch('https://localhost:44343/api/PaymentReceipts', {
        method: 'post',
        headers: headersConstruct(),
        body: JSON.stringify(PaymentReceipt)
    });

    console.log(response);
}

function getDateNow() {
    var now = new Date();
    var dateString = moment(now).format('YYYY-MM-DD');

    return dateString;
}

function generateDescription() {
    return "Compra realizada em " + getDateNow();
}