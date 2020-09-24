
function getUsername() {
    const user = JSON.parse(localStorage.getItem("user"));
    const username = document.getElementById("username");
    username.innerHTML = "Bem-vindo, "+user.personName+"!";
};

function onlyUnique(value, index, self) {
    return self.indexOf(value) === index;
}

function randomBitcoinNews() {
    const bitcoinNews = JSON.parse(getBitcoinsNews());
    let news = [];
    
    for (i = 0; i < 3; i++) {
        news.push(Math.floor(Math.random() * 20))[i]
    }

    console.log(bitcoinNews.articles[news[0]]);
    console.log(bitcoinNews.articles[news[1]]);
    console.log(bitcoinNews.articles[news[2]]);
    
}

function getBitcoinsNews() {    
    const url = 'https://newsapi.org/v2/' +
        'everything?q=bitcoin&from=2020-08-23&sortBy=publishedAt&' +
        'apiKey=d147c585d166461a80ae5aab595fb006';
    const req = new Request(url);
    fetch(req)
        .then(response => response.json())
        .then((data) => localStorage.setItem('articles', JSON.stringify(data)));

    const articles = localStorage.getItem('articles');    
    return articles;
}

getUsername();
randomBitcoinNews();
