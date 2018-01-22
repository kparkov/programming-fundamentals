# Klasser

Klasser er endestationen for dette kursus, og derfor også det sidste, vi egentlig kommer til at lære. Det er her vi lærer, hvorfor det egentlig hedder _objektorienteret programmering_.

## Øvelse: Gladiator fight

## Beslutningstræ for det overordnede spil

![decision-tree-game](http://www.plantuml.com/plantuml/svg/VL0nRiCm39ojLnmojGKyv0Dkbg9JWwATWY834r6EK4a493f6VbywDJfsEXnvHnnlrvIgJZcvXwT7zFs0psM0aJAxRk6lNBYICiP4Ff9ARR-BztZ-Xiw2IiLBHeZZHVc-7V31JTALSPPy8bqDbHiNXS6KrjcRcCWpUOpJ3IeOArtvHjKxryM0pNxA9wwGi9wYeWq3jiyRw8MBwxe-ST1--3fmE_uJYbFZHUrbBgRUo_4la1t278lzkGWirKlnQmDtQjMOl_WOtCx0sle1 "decision-tree-game")

## Beslutningstræ for en enkelt kamp

![decision-tree](http://www.plantuml.com/plantuml/svg/TL6xJWCn4ApjhrYv0gJxXJp4DMbIa0f55EQyZbVux9EzuNwVjIuNa83EcjcPqOntbMtXwnZrmzCZTDq6pAaXuEaIsEW5mOW3WnsOFd5XiDouFRCTFY1FKqwOLiLBZX5yBk3GOwfej2OFfYS7Cq8WtXgjkeYUkytv5UlRJuaTxGKRx_AScbkFxYhvlkJn7bIR2qoPv2dkwY3sXtgd9TYwhG4EcBHQhSwze9BrdCTtspecgW6T-Ru0cK4hZ1KRLbfLaUsZ51VTQIOUmgyX52P7NY-gDUgO_nSiz_esm1yZxkH2FkKB "decision-tree")

## Klassediagram

![classes](http://www.plantuml.com/plantuml/svg/VLLDZzem43qtlyB7e2tyWLPe4QYq4ejMGTqUgXvCCfkrwjYHxO0gn7-lFqWy9i0fUEQzcUUPyV2i3LMcQtYMbPngJLwLh1Ljo2dxz4HErcjOUIO7oIhoGfd8jL5CrB__4AfgFSdEFM_HjfoL5Ys5utf2qOaSGTQSLemQgRwn-iCifJ1ASWxAuQTamxJvEa3cP2cRFJLK64rEf0RpXPnlmTQA7k0VLHL2FP4-_PesO2LONWXNWEwu8SwyaR8DBWzUAg06Xi0Q2m_SQy5C65B8JbJRhjaxOyYl1n59IYl6NpiVKX3wEPQ4xBqK7oyo_F41Or28URvp4ROmXfP_exvpwbx1EuZgohsNafFlp2H6TzyLRMWDqNnLejiAVZ4XxkRVI8rzus49qSBOaQrjtBZGJbcuvgwKwWx0NrJ30uIzyAjaQE0kxaIm6nbyl0WJLjW4bqwZjicsbGA4cQHbBEmmvP7qGoyuEm0Ul1M3C6l3Gooeg6H3bF_quNQi0ZtgbRF-R1EpZHSIkXyEenrp4bzCK8Jobx3isj02ZrXKLUvKLGn6j3vlruI3VwhMCYTlb7UGFAat1aSKTlSXZpktYLv0QrkQV9Au2cZixh5rHk_pUX5mUxvYnKUHumUY_2V5uldDas6-XNRxuuADNJxwCKTtTCEga_5TWmaDt8QzPA7zlftDvdY7PdYVEj-zvPdTtQgOz00rcu_ssmCqXtTZ6QvzsMWjnbYXEBSHg1Kt05Zqs8lJzyCffvKyYgcRwIYSpBhM0dqBi5Mv2rd7XPnbsRDTV_R_xpy0 "classes")

## Gantt

```mermaid
gantt
       dateFormat  YYYY-MM-DD
       title API project

       section API development
	   Sandkasse			:done		api0, 1w
	   Sprintopsætning 		:		api1, after api0, 1w

```

       #Completed task            :done,    des1, 2014-01-06,2014-01-08
       #Active task               :active,  des2, 2014-01-06, 3d
       #Future task               :         des3, after des2, 5d
       #Future task2              :         des4, after des3, 5d

       #section Critical tasks
       #Completed task in the critical line :crit, done, 2014-01-06,24h
       #Implement parser and jison          :crit, done, after des1, 2d
       #Create tests for parser             :crit, active, 3d
       Future task in critical line        :crit, 5d
       Create tests for renderer           :2d
       Add to mermaid                      :1d

       section Documentation
       Describe gantt syntax               :active, a1, after des1, 3d
       Add gantt diagram to demo page      :after a1  , 20h
       Add another diagram to demo page    :doc1, after a1  , 48h

       section Last section
       Describe gantt syntax               :after doc1, 3d
       Add gantt diagram to demo page      :20h
       Add another diagram to demo page    :48h