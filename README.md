# MyAdvance
my notes are kept here in case I forget something

<source lang="cs">
    void Start(){
        OfferSheduler = new Sheduler(currentLevel);

        callAddBanner = new Condition("Вызов Рекламы");
        callAddBanner.setedSeconds = 80; // Кондиция настроенна на 80 секунд
        OfferBuyVip = new Condition("Предложение купить VIP без рекламы");

        OfferSheduler.Add(callAddBanner, 
            delegate()
            {
                Debug.Log("ЗАПУСК РЕКЛАМЫ");
                OfferBuyVip.setedSkips = 2; // Ставим счетчик скипов
                OfferBuyVip.START();  // Запускаем
            }
           );
        OfferSheduler.Add(OfferBuyVip,
            delegate ()
            {
                Debug.Log("Не желаете ли вы купить VIP");
                OfferBuyVip.setedSkips = 0; // Обязательно сбрасываем, запуск рекламы решает, когда запускать
            }
           );
        }
        
        void Finish(){
            OfferSheduler.NextCheckPoint(currentLevel); // не забываем про отсчет пойнтов
            OfferSheduler.Invoke(); // Теперь на финише будут вызываться согласно порядку наши кондиции
        }
</source>
<br>
