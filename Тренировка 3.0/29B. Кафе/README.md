# 29B. Кафе

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
Около Петиного университета недавно открылось новое кафе, в котором действует следующая система скидок: при каждой покупке более чем на 100 рублей покупатель получает купон, дающий право на один бесплатный обед (при покупке на сумму 100 рублей и меньше такой купон покупатель не получает).

Однажды Пете на глаза попался прейскурант на ближайшие *N* дней. Внимательно его изучив, он решил, что будет обедать в этом кафе все *N* дней, причем каждый день он будет покупать в кафе ровно один обед. Однако стипендия у Пети небольшая, и поэтому он хочет по максимуму использовать предоставляемую систему скидок так, чтобы его суммарные затраты были минимальны. Требуется найти минимально возможную суммарную стоимость обедов и номера дней, в которые Пете следует воспользоваться купонами.

## Формат ввода

В первой строке входного файла записано целое число *N (0 ≤ N ≤ 100).* В каждой из последующих *N* строк записано одно целое число, обозначающее стоимость обеда в рублях на соответствующий день. Стоимость — неотрицательное целое число, не превосходящее 300.

## Формат вывода

В первой строке выдайте минимальную возможную суммарную стоимость обедов. Во второй строке выдайте два числа *K<sub>1</sub> и K<sub>2</sub>* — количество купонов, которые останутся неиспользованными у Пети после этих N дней и количество использованных им купонов соответственно.

В последующих *K<sub>2</sub>* строках выдайте в возрастающем порядке номера дней, когда Пете следует воспользоваться купонами. Если существует несколько решений с минимальной суммарной стоимостью, то выдайте то из них, в котором значение *K<sub>1</sub>* максимально (на случай, если Петя когда-нибудь ещё решит заглянуть в это кафе). Если таких решений несколько, выведите любое из них.

## Пример

|Ввод|Вывод|
|---|---|
|5<br>35<br>40<br>101<br>59<br>63|235<br>0 1<br>5|
