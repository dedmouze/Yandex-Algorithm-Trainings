# 38A. Игрушечный лабиринт

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
Игрушечный лабиринт представляет собой прозрачную плоскую прямоугольную коробку, внутри которой есть препятствия и перемещается шарик. Лабиринт можно наклонять влево, вправо, к себе или от себя, после каждого наклона шарик перемещается в заданном направлении до ближайшего препятствия или до стенки лабиринта, после чего останавливается. Целью игры является загнать шарик в одно из специальных отверстий – выходов. Шарик проваливается в отверстие, если оно встречается на его пути (шарик не обязан останавливаться в отверстии).

Первоначально шарик находится в левом верхнем углу лабиринта. Гарантируется, что решение существует и левый верхний угол не занят препятствием или отверстием.

## Формат ввода

В первой строке входного файла записаны числа *N и M* – размеры лабиринта (целые положительные числа, не превышающие *100*). Затем идет *N* строк по *M* чисел в каждой – описание лабиринта. Число 0 в описании означает свободное место, число 1 – препятствие, число 2 – отверстие.

## Формат вывода

Выведите единственное число – минимальное количество наклонов, которые необходимо сделать, чтобы шарик покинул лабиринт через одно из отверстий.

## Пример

|Ввод|Вывод|
|---|---|
|4 5<br>0 0 0 0 1<br>0 1 1 0 2<br>0 2 1 0 0<br>0 0 1 0 0|3|
