# Практические задания по теме «Наследование, свойства, абстрактные классы»
### Задача 1.
Создать иерархию классов Person-Student-Teacher. Каждый класс – в своей сборке. В каждом классе должны быть свойства, а также виртуальная функция Print и переопределенная функция ToString(). Основная программа создает массив объектов Person или их наследников, после чего выдает его на экран. У каждого Teacher должен быть список Students, которыми он руководит, у каждого Student - Teacher, который им руководит.

### Задача 2.
Задан класс *Book*, который описывает книгу. Класс содержит следующие элементы:
- название книги;
- фамилия и имя автора;
- стоимость книги.
В классе Book нужно реализовать следующие методы:
- конструктор с 3 параметрами;
- свойства get/set для доступа к полям класса;
- метод Print(), который выводит информацию о книге.

Разработать класс *BookGenre*, который наследует возможности класса Book и добавляет поле жанра (genre). В классе BookGenre реализовать следующие элементы:
- конструктор с 4 параметрами – реализует вызов конструктора базового класса;
- свойство get/set доступа к внутреннему полю класса;
- метод Print(), который обращается к методу Print() базового класса Book для вывода информации о всех полях класса.

Разработать класс *BookGenrePubl*, который унаследован от класса BookGenre. Данный класс добавляет поле, которое содержит информацию об издателе. В классе BookGenrePubl реализовать следующие элементы:
- конструктор с 5 параметрами;
- свойство get/set для доступа к внутреннему полю класса;
- метод Print(), который вызывает одноименный метод базового класса и выводит на экран информацию об издателе.

Класс BookGenrePubl сделать таким, что не может быть унаследован.

### Задача 3.
Разработать абстрактный класс *Figure*, в котором нужно реализовать следующие элементы:
- скрытое внутреннее поле name (название фигуры);
- конструктор с 1 параметром, инициализирующий поле name заданным значением;
- свойство Name для доступа к внутреннему полю name;
- абстрактное свойство Area2, предназначенное для получения площади фигуры;
- абстрактный метод Area(), предназначенный для получения площади фигуры;
- виртуальный метод Print(), который выводит название фигуры.

Разработать класс *Triangle*, который наследует (расширяет) возможности класса Figure. В классе нужно реализовать следующие элементы:
- скрытые внутренние поля a, b, c (стороны треугольника);
- конструктор с 4 параметрами;
- методы доступа к полям класса SetABC(), GetABC(). Каждый метод получает 3 параметра – длины сторон треугольника;
- свойство Area2, которое определяет площадь треугольника на основании его сторон a, b, c;
- метод Area(), возвращающий площадь треугольника по его сторонам;
- виртуальный метод Print() для вывода внутренних полей класса. Метод обращается к одноименному методу базового класса.

Разработать класс *TriangleColor*, который наследует (расширяет) возможности класса Triangle. В классе реализовать следующие элементы:
- скрытое внутреннее поле color (цвет фона треугольника);
- конструктор с 5 параметрами, вызывающий конструктор базового класса;
- свойство Color, которое предназначено для доступа к внутреннему полю color;
- свойство Area2, вызывающее одноименное свойство базового класса для вычисления площади треугольника;
- метод Area(), возвращающий площадь треугольника по его сторонам;
- виртуальный метод Print() для вывода внутренних полей класса. Метод обращается к одноименному методу базового класса.
