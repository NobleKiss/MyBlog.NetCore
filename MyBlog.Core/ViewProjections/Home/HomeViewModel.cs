﻿using MyBlog.Posts;
using MyBlog.Tags;
using System.Collections.Generic;


namespace MyBlog.ViewProjections.Home
{
    /// <summary>
    /// 首页视图模型
    /// </summary>
    public class HomeViewModel
    {
        /// <summary>
        /// 首页博客列表
        /// </summary>
        public IList<Post> Posts { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        public int PageNum { get; set; }

        /// <summary>
        /// 所有页码
        /// </summary>
        public int AllPageNum { get; set; }

        /// <summary>
        /// 能否下一页
        /// </summary>
        public bool HasNext
        {
            get
            {
                return PageNum < AllPageNum;
            }
        }


        /// <summary>
        /// 能否上一页
        /// </summary>
        public bool HasPrev
        {
            get
            {
                return this.PageNum > 1;
            }
        }

    }
}
