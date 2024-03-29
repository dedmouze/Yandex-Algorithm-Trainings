# 19A. Коммерческий калькулятор

<table>
  <tr>
  	<td>Ограничение времени</td>
  	<td>2 секунды</td>
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
Фирма OISAC выпустила новую версию калькулятора. Этот калькулятор берет с пользователя деньги за совершаемые арифметические операции. Стоимость каждой операции в долларах равна *5%* от числа, которое является результатом операции. На этом калькуляторе требуется вычислить сумму *N* натуральных чисел (числа известны). Нетрудно заметить, что от того, в каком порядке мы будем складывать эти числа, иногда зависит, в какую сумму денег нам обойдется вычисление суммы чисел (тем самым оказывается нарушен классический принцип “от перестановки мест слагаемых сумма не меняется”).

Например, пусть нам нужно сложить числа 10, 11, 12 и 13. Тогда если мы сначала сложим 10 и 11 (это обойдется нам в 1.05 €), потом результат с 12 (1.65 €), и затем с 13 (2.3 €), то всего мы заплатим 5 €, если же сначала отдельно сложить 10 и 11 (1.05 €), потом 12 и 13 (1.25 €) и, наконец, сложить между собой два полученных числа (2.3 €), то в итоге мы заплатим лишь 4.6 €. Напишите программу, которая будет определять, за какую минимальную сумму денег можно найти сумму данных *N* чисел.

## Формат ввода

Первая строка входных данных содержит число *N (2 ≤ N ≤ 10<sup>5</sup>).* Во второй строке заданы *N* натуральных чисел, каждое из которых не превосходит *10000*.

## Формат вывода

Определите, сколько денег нам потребуется на нахождения суммы этих *N* чисел. Результат должен быть выведен с двумя знаками после десятичной точки.

## Примеры

|Ввод|Вывод|
|---|---|
|4<br>10 11 12 13|4.60|
|2<br>1 1|0.10|
