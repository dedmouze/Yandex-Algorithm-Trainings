# D. Клавиатура

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
На региональном этапе Всероссийской олимпиады школьников по информатике в 2009 году предлагалась следующая задача.

Всем известно, что со временем клавиатура изнашивается,и клавиши на ней начинают залипать. Конечно, некоторое время такую клавиатуру еще можно использовать, но для нажатий клавиш приходиться использовать большую силу.

При изготовлении клавиатуры изначально для каждой клавиши задается количество нажатий,которое она должна выдерживать. Если знать эти величины для используемой клавиатуры,то для определенной последовательности нажатых клавиш можно определить, какие клавиши в процессе их использования сломаются, а какие — нет.

Требуется написать программу, определяющую, какие клавиши сломаются в процессе заданного варианта эксплуатации клавиатуры.

## Формат ввода

Первая строка входных данных содержит целое число *n (1 ≤ n ≤ 1000)* —количество клавиш на клавиатуре. Вторая строка содержит *n* целых чисел — *с<sub>1</sub>, с<sub>2</sub>, … , с<sub>n</sub>, где с<sub>i</sub> (1 ≤ c<sub>i</sub> ≤ 10<sup>5</sup>)* — количество нажатий,выдерживаемых *i-ой* клавишей. Третья строка содержит целое число *k (1 ≤ k ≤ 10<sup>5</sup>)* — общее количество нажатий клавиш, и последняя строка содержит *k* целых чисел *p<sub>j</sub> (1 ≤ p<sub>j</sub> ≤ n)* — последовательность нажатых клавиш.

## Формат вывода

Программа должна вывести *n* строк, содержащих информацию об исправности клавиш.Если *i-я* клавиша сломалась, то *i-ая* строка должна содержать слово *YES*, если же клавиша работоспособна — слово *NO*.

## Пример

|Ввод|Вывод|
|---|---|
|5<br>1 50 3 4 3<br>16<br>1 2 3 4 5 1 3 3 4 5 5 5 5 5 4 5|YES<br>NO<br>NO<br>NO<br>YES
