# 37B. Путь в графе

<table>
  <tr>
  <td></td>
    <td>Все языки</td>
    <td>Python 3.6</td>
  </tr>
  <tr>
  	<td>Ограничение времени</td>
  	<td>1 секунда</td>
    <td>5 секунд</td>
  </tr>
  <tr>
  	<td>Ограничение памяти</td>
  	<td>64Mb</td>
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
В неориентированном графе требуется найти минимальный путь между двумя вершинами.

## Формат ввода

Первым на вход поступает число *N* – количество вершин в графе *(1 ≤ N ≤ 100)*. Затем записана матрица смежности (0 обозначает отсутствие ребра, 1 – наличие ребра). Далее задаются номера двух вершин – начальной и конечной.

## Формат вывода

Выведите сначала *L* – длину кратчайшего пути (количество ребер, которые нужно пройти), а потом сам путь. Если путь имеет длину 0, то его выводить не нужно, достаточно вывести длину.

Необходимо вывести путь (номера всех вершин в правильном порядке). Если пути нет, нужно вывести -1.

## Пример

|Ввод|Вывод|
|---|---|
|10<br>0 1 0 0 0 0 0 0 0 0<br>1 0 0 1 1 0 1 0 0 0<br>0 0 0 0 1 0 0 0 1 0<br>0 1 0 0 0 0 1 0 0 0<br>0 1 1 0 0 0 0 0 0 1<br>0 0 0 0 0 0 1 0 0 1<br>0 1 0 1 0 1 0 0 0 0<br>0 0 0 0 0 0 0 0 1 0<br>0 0 1 0 0 0 0 1 0 0<br>0 0 0 0 1 1 0 0 0 0<br>5 4|2<br>5 2 4|
