# E. Улучшение успеваемости

<table>
  <tr>
  	<td>Ограничение времени</td>
  	<td>1 секунда</td>
  </tr>
  <tr>
  	<td>Ограничение памяти</td>
  	<td>64Mb</td>
  </tr>
  <tr>
  	<td>Ввод</td>
  	<td>стандартный ввод или input.txt</td>
  </tr>
  <tr>
  	<td>Вывод</td>
  	<td>стандартный вывод или output.txt</td>
  </tr>
</table>

---
В лицее на уроках информатики ответы учеников оцениваются целым числом баллов от 2 до 5 . Итоговая оценка по информатике выставляется как среднее арифметическое оценок на всех уроках, округленное до ближайшего целого числа. Если среднее значение находится ровно посередине между двумя целыми числами, то оценка округляется вверх.

Примеры округления оценок приведены в таблице.

<p align="center">
    <img width="666" height="210" src="https://github.com/dedmouze/Yandex-Algorithm-Trainings/blob/main/%D0%A2%D1%80%D0%B5%D0%BD%D0%B8%D1%80%D0%BE%D0%B2%D0%BA%D0%B0%201.0/06.%20%D0%91%D0%B8%D0%BD%D0%B0%D1%80%D0%BD%D1%8B%D0%B9%20%D0%BF%D0%BE%D0%B8%D1%81%D0%BA/E.%20%D0%A3%D0%BB%D1%83%D1%87%D1%88%D0%B5%D0%BD%D0%B8%D0%B5%20%D1%83%D1%81%D0%BF%D0%B5%D0%B2%D0%B0%D0%B5%D0%BC%D0%BE%D1%81%D1%82%D0%B8/%D0%9F%D1%80%D0%B8%D0%BC%D0%B5%D1%80%D1%8B%20%D0%BE%D0%BA%D1%80%D1%83%D0%B3%D0%BB%D0%B5%D0%BD%D0%B8%D1%8F%20%D0%BE%D1%86%D0%B5%D0%BD%D0%BE%D0%BA.png" alt="Пример округления оценок">
</p>

Все ученики лицея стремятся получить итоговую оценку по информатике не ниже 4 баллов. К сожалению, один из учеников получил на уроках *a* двоек, *b* троек и *c* четверок. Теперь он планирует получить несколько пятерок, причем хочет, чтобы итоговая оценка была не меньше 4 баллов. Ему надо понять, какое минимальное количество пятерок ему необходимо получить, чтобы добиться своей цели.

Требуется написать программу, которая по заданным целым неотрицательные числам *a, b и c* определяет минимальное количество пятерок, которое необходимо получить ученику, чтобы его итоговая оценка по информатике была не меньше 4 баллов.

## Формат ввода

Входные данные содержат три строки. Первая строка содержит целое неотрицательное число *a*, вторая строка содержит целое неотрицательное число *b*, третья строка содержит целое неотрицательное число *c (0 ≤ a, b, c ≤ 10<sup>15</sup>, a + b + c ≥ 1)*.

## Формат вывода

Выходные данные должны содержать одно число: минимальное число пятерок, которое необходимо получить ученику, чтобы итоговая оценка была не меньше 4 баллов.

## Пример

|Ввод|Вывод|
|---|---|
|2<br>0<br>0|2|
