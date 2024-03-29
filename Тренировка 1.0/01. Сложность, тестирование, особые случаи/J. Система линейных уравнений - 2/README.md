# J. Система линейных уравнений - 2

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
Даны числа a, b, c, d, e, f. Решите систему линейных уравнений:

$$\begin{cases}
ax + by = e\\
cx + dy = f
\end{cases}$$

## Формат ввода

Вводятся 6 **вещественных** чисел - коэффициенты уравнений.

## Формат вывода

Вывод программы зависит от вида решения этой системы. Если система не имеет решений, то программа должна вывести единственное число 0. Если система имеет бесконечно много решений, каждое из которых имеет вид *y = kx + b*, то программа должна вывести число 1, а затем значения *k и b*. Если система имеет единственное решение *(x<sub>0</sub>, y<sub>0</sub>)*, то программа должна вывести число 2, а затем значения *x<sub>0</sub> и y<sub>0</sub>*. Если система имеет бесконечно много решений вида *x = x<sub>0</sub>, y* — любое, то программа должна вывести число 3, а затем значение *x<sub>0</sub>*. Если система имеет бесконечно много решений вида *y = y<sub>0</sub>, x* — любое, то программа должна вывести число 4, а затем значение *y<sub>0</sub>*. Если любая пара чисел *(x, y)* является решением, то программа должна вывести число 5.

Числа *x<sub>0</sub> и y<sub>0</sub>* будут проверяться с точностью до пяти знаков после точки.

## Примеры

|Ввод|Вывод|
|---|---|
|1<br>0<br>0<br>1<br>3<br>3|2 3 3|
|1<br>1<br>2<br>2<br>1<br>2|1 -1 1|
|0<br>2<br>0<br>4<br>1<br>2|4 0.5|
