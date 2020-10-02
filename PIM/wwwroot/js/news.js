function getTitleNews() {
    const news = document.getElementsByClassName("card-title");
    const newsImg = document.getElementsByClassName("card-img-top");
    const newsDescription = document.getElementsByClassName("card-text");
    //const news = document.getElementsByClassName("card-title");
    const articles = JSON.parse(localStorage.getItem('articles'));
    for (let i = 0; i < news.length; i++) {
        news[i].innerHTML = articles.articles[i].title
        newsImg[i].src = articles.articles[i].urlToImage
        newsDescription[i].innerHTML = articles.articles[i].description
    }
}

getTitleNews();