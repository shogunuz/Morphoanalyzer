As soon as we start IIS Express, the default controller window (Weather) will open.
This is done in order to check if the server is running or not. It is planned to replace the weather controller by other one.

The system works according to the following principle:
A word (data type: string) is sent to the server, then, the system starts
searching for this word in the Exception dataset. There are around 10 datasets in total.
First 8 are datasets of main parts of speech (Nouns - Exception Nouns, Verbs - Exception Verbs and e.g.)
Datesets have not been migrated to SQL version yet, due to some technical problems.

Returning to the algorithm of the system, as soon as the system receives a word, first it looks for it
in exception datasets, if it finds it, it will return the result. However, if it doesn't find sent word in exception datasets, then it will run the algorithm in order to 
truncate the endings to find the root of the word. Separate classes are created for each part of speech,
which inherit from the main class. In general, the relationship between classes is implemented using
design pattern SOLID (mostly for using Depend. inj). It helps to scale the project to the extent required.

So, as soon as the original (sent) word is truncated by classes of parts of speech, the system analyzes in which
class revealed the most truncated endings. Depending on the number of truncated endings,
the system decides which part of speech this word belongs to. And all the truncated endings and
the root of the word is placed in a Dictionary, then serialized to json format and sent
back to the client (frontend). It should be that algorithm can truncatinate sent word 3 times for each part of speech.
What I mean by this is that Noun and Verb cannot have more than 3 affixes, while adjectives and adverbs only 2. 
For instance (Noun): 
We send word 'bolalarimizning' - Analyzed version 'bola' + 'lar' + 'imiz' + 'ning'. In this case we have a root and 3 affixes.



Русская версия...
Сразу после запуска IIS Express вам откроется окошко контроллера по-умолчанию (Weather).
Это сделано для того, чтобы проверить, работает ли сервер или нет. В будущем, он будет
обязательно заменен  другим контроллером.

Система работает по следующему принципу:
На вход post запросом подаётся слово (типа данных: string), затем система первым делом
осуещствляет поиск этого слова в Exception датасете. Всего этих датасетов два. 
Один для существительного, другой для прилагательного. Дата сеты были созданы в виде
статичных строк в самом проекте, ибо пока не выбрали конкретно архитектуру хранения данных.
При необходимости, все датасеты можно без проблем перенести на MS SQL сделав миграцию данных
через EF Core.

Возвращаясь к алгоритму работы системы, как только система принимает слово, сначала она ищет его
в exception датасетах, если находит возвращает результат, а если не находит, запускает алгоритм
усечения окончаний дабы найти корень слова. Для каждой части речи созданы отдельные классы,
которые наследуются от главного класса. Вообще, взаимосвязь между классами реализована с помощью
паттерна проектирования SOLID, а именно, с акцентом на DependencyInjection. Это помогает масштабировать
проект в том объёме, в каком требуется. 

Так вот, как только исходное слово усекается классами частей речи, система анализирует в каком
классе выявилось больше всего усеченных окончаний. В зависимости от количества усеченных окончаний,
система принимает решение к какой части речи относится это слово. А все усеченные окончания и 
корень слова помещаются в словарь (Dictionary), затем, сериализуются в json формат и отправляются
обратно клиенту (пользователю).

Планы:
........

