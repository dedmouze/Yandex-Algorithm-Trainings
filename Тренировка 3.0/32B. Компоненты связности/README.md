# 32B. Компоненты связности

<table>
  <tr>
  <td></td>
    <td>Все языки</td>
    <td>Python 3.6</td>
  </tr>
  <tr>
  	<td>Ограничение времени</td>
  	<td>2 секунды</td>
    <td>5 секунд</td>
  </tr>
  <tr>
  	<td>Ограничение памяти</td>
  	<td>256Mb</td>
    <td>256Mb</td>
  </tr>
  <tr>
  	<td>Ввод</td>
  	<td colspan = "2">стандартный ввод или input.txt</td>
  </tr>
  <tr>
  	<td>Вывод</td>
  	<td colspan = "2">стандартный вывод или output.txt</td>
  </tr>
</table>

---
Дан неориентированный невзвешенный граф, состоящий из *N* вершин и *M* ребер. Необходимо посчитать количество его компонент связности и вывести их.

## Формат ввода

Во входном файле записано два числа *N и M (0 < N ≤ 100000, 0 ≤ M ≤ 100000).* В следующих *M* строках записаны по два числа *i и j (1 ≤ i, j ≤ N)*, которые означают, что вершины *i и j* соединены ребром.

## Формат вывода

В первой строчке выходного файла выведите количество компонент связности. Далее выведите сами компоненты связности в следующем формате: в первой строке количество вершин в компоненте, во второй - сами вершины в произвольном порядке.

## Примеры

|Ввод|Вывод|
|---|---|
|6 4<br>3 1<br>1 2<br>5 4<br>2 3|3<br>3<br>1 2 3<br>2<br>4 5<br>1<br>6|
|6 4<br>4 2<br>1 4<br>6 4<br>3 6|2<br>5<br>1 2 3 4 6<br>1<br>5|
