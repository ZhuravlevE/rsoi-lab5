﻿using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Gateway.Utils
{
    /// <summary>
    /// Вспомогательный класс для работы с SymmetricSecurityKeys.
    /// </summary>
    public class SymmetricSecurityKeysHelper
    {
        /// <summary>
        /// Генерирует симметричный ключ по <paramref name="rawString"/>
        /// </summary>
        /// <param name="rawString"></param>
        /// <returns></returns>
        public static SymmetricSecurityKey GetSymmetricSecurityKey(string rawString)
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(rawString));
        }
    }
}
