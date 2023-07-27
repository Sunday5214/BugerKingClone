using CommunityToolkit.Mvvm.ComponentModel;

namespace MugerKing.ViewModels
{
    public class DeliveryModel
    {
        /// <summary>
        /// 이미지 or 이미지URL
        /// </summary>
        public string Image { get; set; } = "/bugerking_img_in_coupon.webp";

        /// <summary>
        /// 제목
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 판매가격
        /// </summary>
        public int Price { get; set; }

        /// <summary>
        /// 할인율
        /// </summary>
        public int Discount { get; set; }

        /// <summary>
        /// 할인가격
        /// </summary>
        public int DiscountPrice { get; set; }

        /// <summary>
        /// 종료일자
        /// </summary>
        public DateTime EndDate { get; set; }
    }

    public partial class DeliveryViewModel : ObservableObject
    {
        [ObservableProperty]
        private List<DeliveryModel> deliveryModels;

        public DeliveryViewModel()
        {
            deliveryModels = new List<DeliveryModel>()
            {
                new DeliveryModel()
                {
                    Title = "[NEW⭐] 헬로 디아블로 와퍼+코카콜라(R)",
                    Price = 15000,
                    Discount = 13,
                    DiscountPrice = 13000,
                    EndDate = DateTime.Now.AddDays(-10)
                },
                new DeliveryModel()
                {
                    Title = "바비큐치킨버거+코카콜라(R)",
                    Price = 5700,
                    Discount = 35,
                    DiscountPrice = 3700,
                    EndDate = DateTime.Now.AddDays(-3)
                },
                new DeliveryModel()
                {
                    Title = "불고기와퍼 세트",
                    Price =  9000,
                    Discount = 10,
                    DiscountPrice = 8100,
                    EndDate = DateTime.Now.AddDays(-5)
                },
                new DeliveryModel()
                {
                    Title = "[신제품팩⭐]헬로이나리우스와퍼세트+헬로릴리트와퍼+콜라(R)+21치즈스틱 ",
                    Price = 25500,
                    Discount = 21,
                    DiscountPrice = 19900,
                    EndDate = DateTime.Now.AddDays(14)
                },
                new DeliveryModel()
                {
                    Title = "[특별 팩⭐] 치즈와퍼세트+통새우와퍼+코카콜라(R)+21치즈스틱",
                    Price = 22100,
                    Discount = 23,
                    DiscountPrice = 16900,
                    EndDate = DateTime.Now.AddDays(5)
                }
            };
        }
    }
}