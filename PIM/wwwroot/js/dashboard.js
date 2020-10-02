function getUsername() {
    const user = JSON.parse(localStorage.getItem("user"));
    const username = document.getElementById("usernameMessage");
    username.innerHTML = "Bem vindo, "+user.personName+"!";
};

function randomBitcoinNews() {
    const bitcoinNews = JSON.parse(getBitcoinsNewsInfo());
    let randomIndexes = [];

    for (i = 0; i < 3; i++) {
        randomIndexes.push(Math.floor(Math.random() * 20))[i]
    }

    const htmlNews = document.getElementsByName("news");

    htmlNews[0].innerHTML = "UOLAC";

    for (let i = 0; i < htmlNews.length; i++) {
        htmlNews[i].innerHTML = bitcoinNews.articles[randomIndexes[i]].title;
    };

    getNewsLink(randomIndexes);
    setBitcoinsInfo();
}

function getNewsLink(indexs) {

    const bitcoinNews = JSON.parse(getBitcoinsNewsInfo());
    const newsLinks = document.getElementsByName("linknews");

    for (let i = 0; i < newsLinks.length; i++) {
        newsLinks[i].href = bitcoinNews.articles[indexs[i]].url
    }

}

function getBitcoinsNewsInfo() {
    const url = 'https://newsapi.org/v2/' +
        'everything?q=bitcoin&from=2020-10-01&sortBy=publishedAt&apiKey=d147c585d166461a80ae5aab595fb006';
    const req = new Request(url);
    fetch(req)
        .then(response => response.json())
        .then((data) => localStorage.setItem('articles', JSON.stringify(data)));

    const articles = localStorage.getItem('articles');
    return articles;
}

function setBitcoinsInfo() {
    const url = 'https://api.nomics.com/v1/currencies/ticker?key=5c9f6330e6d7cc028f4d956b3255fedd&ids=BTC,ETH,XRP&interval=1d,30d&convert=EUR'
    let paragrafo = document.getElementsByName("bitcoinInfo");
    let paragrafoMoney = document.getElementsByName("bitcoinMoney");


    const req = new Request(url);
    fetch(req)
        .then(response => response.json())
        .then((data) => localStorage.setItem('crypto', JSON.stringify(data)));

    const cryptoCurrency = JSON.parse(localStorage.getItem('crypto'));
    for (let i = 0; i < paragrafo.length; i++) {
        paragrafo[i].innerHTML = cryptoCurrency[i].id + " - " + cryptoCurrency[i].name;
    };

    for (let i = 0; i < paragrafoMoney.length; i++) {
        paragrafoMoney[i].innerHTML = cryptoCurrency[i].price + " U$";
    };

}

randomBitcoinNews();
getUsername();
