﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fx.Domain.FxAggregate.IService;
using Fx.Domain.FxHouse.IService;

namespace Fx.InformationPlatform.Site.Controllers
{
    /// <summary>
    /// 具体房屋转让详情页面
    /// </summary>
    public class HouseTransferDetailController : Controller
    {
       protected ITransferHouse transferHouse;
       protected IFavorite favorite;
       public HouseTransferDetailController(ITransferHouse transferHouse,
           IFavorite favorite)
        {
            this.transferHouse = transferHouse;
            this.favorite = favorite;
        }

        public ActionResult Index(int id)
        {
            if (id <= 0)
            {
                return RedirectToAction("PageNotFound", "PageLink");
            }
            else
            {
                var house = transferHouse.Get(id);
                if (house == null)
                {
                    return RedirectToAction("PageNotFound", "PageLink");
                }
                if (User.Identity.IsAuthenticated)
                {
                    var isFav = favorite.IsFavorite((int)Fx.Entity.ChannelCatagroy.FxHouseTrasnfer, id, User.Identity.Name);
                    ViewBag.IsFav = isFav;
                }
                else
                {
                    ViewBag.IsFav = false;
                }
                return View(house);
            }
        }

        public ActionResult Favorite(int infoId)
        {
            if (infoId > 0 && User.Identity.IsAuthenticated)
            {
                var house = transferHouse.Get(infoId);
                var ret = favorite.AddFavorite(new Entity.FxAggregate.Favorite()
                {
                    ChannelCatagroy = (int)Fx.Entity.ChannelCatagroy.FxHouseTrasnfer,
                    InfoId = infoId,
                    Title = house.PublishTitle,
                    UserAccount = User.Identity.Name
                });
                if (ret.isSuccess)
                {
                    TempData["Tip"] = "收藏成功";
                }
                else
                {
                    TempData["Tip"] = ret.ResultMsg;
                }
            }
            else
            {
                TempData["Tip"] = "收藏失败,您没有登录,请先登陆";
            }
            return RedirectToAction("Index", new { id = infoId });
        }
    }
}
