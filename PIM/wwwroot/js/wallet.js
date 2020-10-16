new Chart(document.getElementById("line-chart"), {
    type: 'line',
    data: {
        labels: [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19,
            20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30],
        datasets: [{
            data: [86, 114, 106, 106, 107, 111, 133, 221, 783, 2478],
            label: "Esperado",
            borderColor: "#3e95cd",
            fill: false
        }, {
            data: [282, 350, 411, 502, 635, 809, 947, 1402, 3700, 5267],
            label: "Atualmente",
            borderColor: "#8e5ea2",
            fill: false
        },]
    },
    options: {
        title: {
            display: true,
            text: 'Projeções'
        }
    }
});