# 40B. Метро

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
Метрополитен состоит из нескольких линий метро. Все станции метро в городе пронумерованы натуральными числами от *1 до N*. На каждой линии расположено несколько станций. Если одна и та же станция расположена сразу на нескольких линиях, то она является станцией пересадки и на этой станции можно пересесть с любой линии, которая через нее проходит, на любую другую (опять же проходящую через нее).

Напишите программу, которая по данному вам описанию метрополитена определит, с каким минимальным числом пересадок можно добраться со станции *A* на станцию *B*. Если данный метрополитен не соединяет все линии в одну систему, то может так получиться, что со станции *A* на станцию *B* добраться невозможно, в этом случае ваша программа должна это определить.

## Формат ввода

Сначала вводится число *N* — количество станций метро в городе *(2 ≤ N ≤ 100)*. Далее следует число *M* — количество линий метро *(1 ≤ M ≤ 20).* Далее идет описание *M* линий. Описание каждой линии состоит из числа *P<sub>i</sub>* — количество станций на этой линии *(2 ≤ *P<sub>i</sub>* ≤ 50)* и *P<sub>i</sub>* чисел, задающих номера станций, через которые проходит линия (ни через какую станцию линия не проходит дважды).

Затем вводятся два различных числа: *A* — номер начальной станции, и *B* — номер станции, на которую нам нужно попасть. При этом если через станцию *A* проходит несколько линий, то мы можем спуститься на любую из них. Так же если через станцию B проходит несколько линий, то нам не важно, по какой линии мы приедем.

## Формат вывода

Выведите минимальное количество пересадок, которое нам понадобится. Если добраться со станции *A* на станцию *B* невозможно, программа должна вывести одно число –1 (минус один).

## Пример

|Ввод|Вывод|
|---|---|
|5<br>2<br>4 1 2 3 4<br>2 5 3<br>3 1|0|
