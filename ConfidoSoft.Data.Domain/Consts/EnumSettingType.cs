﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConfidoSoft.Data.Domain.Consts
{
    /// <summary>
    /// Indicate type of the setting, which decide information/object type to be stored for that setting type!
    /// </summary>
    public enum EnumSettingType
    {
        /// <summary>
        /// Default and it is not valid value!
        /// </summary>
        None = 0,

        #region Security Type settings
        
        /// <summary>
        /// Store Encryption Key for rest of all setting and other encrypted table data.
        /// </summary>
        EncryptionKeySettings,

        /// <summary>
        /// Previous Encryption Key setting in case we allow to change the Encryption key from 
        /// application.
        /// </summary>
        PreviousEncryptionKeySettings,

        /// <summary>
        /// SMTP related setting.
        /// </summary>
        SMTPSettings,

        /// <summary>
        /// SMS related Setting. e.g. Twilio setting.
        /// </summary>
        SMSSettings,


        //AuthenticationSettings, // setting like TwoFactorAuthentication, reset password days.
        //AzureAuthentication, //Azure Authentication provider related settings
        //PasswordPolicySettings, // password policy settings
        //OpenIDSettings, // OpenID External login settings

        #endregion
    }


}
