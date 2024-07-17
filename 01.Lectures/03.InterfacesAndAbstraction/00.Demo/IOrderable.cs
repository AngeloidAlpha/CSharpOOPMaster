using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Demo
{
    public interface IOrderable
    {
     // идеята на интерфейса е да покажеме само Relevant информация и да скрием Irelevant
     // имаме 2 класа Cook и Waiter
     // те имат дубликираща се информация която може да абстрахираме в интерфейс
     // интерфейса винаги е публичен (за да се използва от всичко което има нужда от него)
     // методите са абстрактните методи са задължителни за имплементация
     // но не се пише Public abstract по подразбиране
        public abstract void Order(string menuItem);



    }
}
