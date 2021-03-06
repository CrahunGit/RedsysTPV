﻿using RedsysTPV.Converters;
using RedsysTPV.Enums;
using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace RedsysTPV.Models
{
    public class PaymentResponse
    {
        public string Ds_Date { get; set; }
        public string Ds_Hour { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
        [JsonConverter(typeof(CurrencyToStringJsonConverter))]
        public decimal Ds_Amount { get; set; }
        [JsonConverter(typeof(EnumToThreeStringConverter<Currency>))]
        public Currency Ds_Currency { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
        public string Ds_Order { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
        public string Ds_MerchantCode { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
        public string Ds_Terminal { get; set; }
        public string Ds_Response { get; set; }
        /// <summary>
        /// Optional
        /// </summary>
        public string Ds_MerchantData { get; set; }
        public string Ds_SecurePayment { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
        [JsonConverter(typeof(EnumDescriptionConverter<TransactionType>))]
        public TransactionType Ds_TransactionType { get; set; }
        public string Ds_Card_Country { get; set; }
        public string Ds_AuthorisationCode { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
        [JsonConverter(typeof(EnumDescriptionConverter<Language>))]
        public Language Ds_ConsumerLanguage { get; set; }
        public string Ds_Card_Type { get; set; }
        public string Ds_Card_Brand { get; set; }
        public string Ds_Card_Number { get; set; }
        public string Ds_ExpiryDate { get; set; }
        public string Ds_Merchant_Identifier { get; set; }
        public string Ds_ErrorCode { get; set; }
        public string ErrorCode { get; set; }
        public string Codigo { get; set; }
        public string Ds_UrlPago2Fases { get; set; }
        public string Ds_Signature { get; set; }
        public string Ds_Dcc { get; set; }
        public string Ds_Emv3ds { get; set; }
        public string Ds_Excep_SCA { get; set; }
        public string Ds_ProcessedPayMethod { get; set; }
        public string Ds_Merchant_Cof_Txnid { get; set; }
    }
}
