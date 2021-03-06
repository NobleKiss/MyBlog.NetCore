﻿namespace MyBlog.Commands.Account
{
    /// <summary>
    /// 用户注册命令
    /// </summary>
    public class UserRegisterCommand
    {
        /// <summary>
        /// 账号
        /// </summary>
        public string UserAccount { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 确认密码
        /// </summary>
        public string ConfirmPassword { get; set; }
    }
}
