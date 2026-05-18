using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace RedsysTPV.Enums
{
    public enum TransactionType
    {
        [Description("0")]
        Authorization,

        [Description("1")]
        Preauthorization,

        [Description("2")]
        Confirmation,

        [Description("3")]
        AutomaticRefund,

        [Description("5")]
        RecurringTransaction,

        [Description("6")]
        NextTransaction,

        [Description("7")]
        PreauthorisationSeparate,

        [Description("8")]
        ConfirmationSeparate,

        [Description("9")]
        CancellationOfPreauthorisation,

        [Description("15")]
        Paygold,

        [Description("17")]
        AuthenticationPuce,

        [Description("34")]
        DevolucionSinOriginal,

        [Description("37")]
        PremioDeApuestas,

        [Description("44")]
        ConsultaOperaciones
    }
}
