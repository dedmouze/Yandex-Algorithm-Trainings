# B. Номер появления слова

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
Во входном файле (вы можете читать данные из файла input.txt) записан текст. Словом считается последовательность непробельных символов идущих подряд, слова разделены одним или большим числом пробелов или символами конца строки. Для каждого слова из этого текста подсчитайте, сколько раз оно встречалось в этом тексте ранее.

## Формат ввода

Вводится текст.

## Формат вывода

Выведите ответ на задачу.

## Примеры

|Ввод|Вывод|
|---|---|
|one two one tho three|0 0 1 0 0|
|She sells sea shells on the sea shore;<br>The shells that she sells are sea shells I'm sure.<br>So if she sells sea shells on the sea shore,<br>I'm sure that the shells are sea shore shells.|0 0 0 0 0 0 1 0 0 1 0 0 1 0 2 2 0 0 0 0 1 2 3 3 1 1 4 0 1 0 1 2 4 1 5 0 0|
|aba aba; aba @?"|0 0 1 0|
