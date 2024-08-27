using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class StringExtensions
    {
        public static int Words(this string str) =>
            str.Split(" ", StringSplitOptions.RemoveEmptyEntries).Count();
    }
    // 1. static class ichida static method bo'lishi shart
    // 2. this kalit so'zi orqali kerakli classga ulaymiz

    // 1. sealed classlarini extend qilish uchun
    // 2. kutubxonalarni extend qilish uchun
}
