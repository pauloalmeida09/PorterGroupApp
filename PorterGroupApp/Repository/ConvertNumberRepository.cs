using Microsoft.Extensions.Logging;
using PorterGroupApp.Interfaces;
using PorterGroupApp.Models.Request;
using System;

namespace PorterGroupApp.Repository
{
    public class ConvertNumberRepository : IConvertNumberRepository
    {
        private readonly ILogger<ConvertNumberRepository> _logger;

        public ConvertNumberRepository(ILogger<ConvertNumberRepository> logger)
        {
            _logger = logger;
        }

        public string ConvertNumberToWord(NumbersToWordRequest payload)
        {
            try
            {
                string response = "";
                int len = payload.Number.ToString().Replace(" ", "").Length;
                string numberString = payload.Number.ToString();

                if (len > 4)
                {
                    response = "Não é possivel converter Number maior de 4 digitos";
                    return response;
                }

                string[] single_digits = new string[] {
                    "zero", "um", "dois",   "três", "quatro","cinco", "seis", "sete", "oito", "nove"
                };
                string[] two_digits = new string[] {
                    "","dez","onze","doze","treze","quatorze", "quize", "dezesseis","dezessete", "dezoito", "dezenove"
                };
                string[] tens_multiple = new string[] {
                    "","","vinte",  "trinta", "quarenta","cinquenta", "sessenta", "noventa", "oitenta", "noventa"
                };

                if (len == 1)
                {
                    return single_digits[numberString[0] - '0'];
                }
                int x = 0;
                bool numbersBiggers = false;
                bool numbersBiggersFourLenth = false;
                while (x < numberString.Length)
                {

                    if (len == 4)
                    {
                        if (numberString[x] - '0' != 0)
                        {
                            numbersBiggers = true;
                            numbersBiggersFourLenth = true;

                            response = single_digits[numberString[x] - '0'] + " mil";

                        }
                        --len;
                    }
                    else if (len == 3)
                    {
                        if (numberString[x] - '0' != 0)
                        {
                            numbersBiggers = true;
                            if (numberString[x] - '0' == 1)
                            {
                                if (numbersBiggersFourLenth) { response = response + " e cem"; }
                                else { response = "cem"; }
                            }
                            else if (numberString[x] - '0' == 2)
                            {
                                if (numbersBiggersFourLenth) { response = response + " e duzentos"; }
                                else { response = "duzentos"; }
                            }
                            else if (numberString[x] - '0' == 3)
                            {
                                if (numbersBiggersFourLenth) { response = response + " e trezentos"; }
                                else { response = "trezentos"; }
                            }
                            else if (numberString[x] - '0' == 5)
                            {
                                if (numbersBiggersFourLenth) { response = response + " e quientos"; }
                                else { response = "quientos"; }
                            }
                            else
                            {
                                if (numbersBiggersFourLenth) { response = response + " e " + single_digits[numberString[x] - '0'] + "centos"; }
                                else { response = single_digits[numberString[x] - '0'] + "centos"; }
                            }

                        }
                        --len;
                    }
                    else
                    {
                        if (numberString[x] - '0' == 1)
                        {
                            int sum = numberString[x] - '0' + numberString[x + 1] - '0';
                            return response = two_digits[sum];
                        }
                        else if (numberString[x] - '0' == 2
                                 && numberString[x + 1] - '0' == 0)
                        {
                            response = "vinte";
                        }
                        else
                        {
                            int i = (numberString[x] - '0');
                            if (i > 0)
                            {
                                if (response == "cem") { response = "cento"; }
                                if (numbersBiggers)
                                {
                                    response = response + " e " + tens_multiple[i];
                                }
                                else
                                {
                                    response = response + tens_multiple[i];
                                }

                            }
                            else
                            {
                                response = response + "";
                            }

                            ++x;

                            if (numberString[x] - '0' != 0)
                            {
                                // if (response == "cem") { response = "cento"; }
                                // response.Replace("cem", "cento");
                                response = response + " e " + single_digits[numberString[x] - '0'];
                            }
                        }
                    }
                    ++x;
                }

                return response;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                throw;
            }
        }

    }
}
