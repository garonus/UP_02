// Дан массив Q натуральных чисел, содержащий 20 элементов.
// Найти и вывести те элементы, которые при делении на 7 дают остаток 1,2 или 5

let arrQ = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20]

arrQ.forEach(q => {
    if (q % 7 == 1 || q % 7 == 2 || q % 7 == 5) {
        console.log(q)
    }
});


// Написать метод, который вычисляет значения x = sin^2(a) и y = cos^2(a). 
// Напечатать таблицу значений от –π до π с шагом π/4.

for (let i = 1; i < 180; i = i + 45) {

    x = Math.pow(Math.sin(i), 2)
    y = Math.pow(Math.cos(i), 2)

    function toDegrees(angle) {
        return angle * (180 / Math.PI);
    }

    function toRadians(angle) {
        return angle * (Math.PI / 180);
    }

    toDegrees(x)
    toDegrees(y)

    console.log(x - y)
}

// Дан массив, содержащий 12 элементов. 
// Все четные элементы сложить, вывести массив и результат

let arrA = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12]
let arrB = []

arrA.forEach(a => {
    if (a % 2 == 0) {
        arrB.push(a)
    }
});

console.log(arrA)
console.log(arrB)