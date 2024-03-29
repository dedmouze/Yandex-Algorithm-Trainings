# G. Детский праздник

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
Организаторы детского праздника планируют надуть для него *M* воздушных шариков. С этой целью они пригласили N добровольных помощников, *i-й* среди которых надувает шарик за *T<sub>i</sub>* минут, однако каждый раз после надувания *Z<sub>i</sub>* шариков устает и отдыхает *Y<sub>i</sub>* минут. Теперь организаторы праздника хотят узнать, через какое время будут надуты все шарики при наиболее оптимальной работе помощников, и сколько шариков надует каждый из них. (Если помощник надул шарик, и должен отдохнуть, но больше шариков ему надувать не придется, то считается, что он закончил работу сразу после окончания надувания последнего шарика, а не после отдыха).

## Формат ввода

В первой строке входных данных задаются числа *M и N (0 ≤ M ≤ 15 000, 1 ≤ N ≤ 1000)*. Следующие *N* строк содержат по три целых числа - *T<sub>i</sub>, Z<sub>i</sub> и Y<sub>i</sub>* соответственно *(1 ≤ T<sub>i</sub>, Y<sub>i</sub> ≤ 100, 1 ≤ Z<sub>i</sub> ≤ 1000)*.

## Формат вывода

Выведите в первой строке число *T* - время, за которое будут надуты все шарики. Во второй строке выведите *N* чисел - количество шариков, надутых каждым из приглашенных помощников. Разделяйте числа пробелами. Если распределений шариков несколько, выведите любое из них.

## Примеры

|Ввод|Вывод|
|---|---|
|1 2<br>2 1 1<br>1 1 2|1<br>0 1|
|2 2<br>1 1 1<br>1 1 1|1<br>1 1|
