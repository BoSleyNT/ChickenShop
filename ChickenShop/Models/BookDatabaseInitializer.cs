using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ChickenShop.Models
{

        public class BookDatabaseInitializer : DropCreateDatabaseAlways<BookContext>
        {
            protected override void Seed(BookContext context)
            {
                GetCategories().ForEach(c => context.Categories.Add(c));
                GetBooks().ForEach(p => context.Books.Add(p));
            }
            private static List<Category> GetCategories()
            {
                var categories = new List<Category> {
new Category
{
CategoryID = 1,
CategoryName = "Gà cảnh"
},
new Category
{
CategoryID = 2,
CategoryName = "Gà thịt"
},
new Category{
CategoryID = 3,
CategoryName = "Gà trứng"
},
new Category
{
CategoryID = 4,
CategoryName = "Gà chọi"
}
};
                return categories;
            }
            private static List<Book> GetBooks()
            {
            var books = new List<Book> {
//chicken 1
new Book
{
BookID = 1,
BookName = "Gà lông xù Frizzle",
Description = "Giống gà này được đặt tên là Silkie vì có bộ lông đặc trưng được cho là mềm như lụa , đặc trưng của giống gà Silkie là chúng có bộ lông xù như lông chó Nhật, phủ toàn thân và cả phần đầu, sống được ở điều kiện khí hậu ấm và lạnh. Bộ lông này phủ kín thân những con gà Silkie và người ta chỉ có thể nhìn thấy mặt của chúng[2]. Chúng ví von là loài lai giữa gà và thỏ, với bộ lông mang đủ màu sắc.",
ImagePath="Pic1.jpg",
UnitPrice = 431,
CategoryID = 1
},
//chicken 2
new Book
{
BookID = 2,
BookName = "Gà đông tảo",
Description = "Gà thuộc giống gà to con, dáng hình bệ vệ, với thân hình to, da đỏ, đầu oai vệ, cặp chân vững chãi. Gà Đông Tảo trống có hai mãn lông cơ bản gồm mãn mận (màu tím pha đen) và màu của trái mận. Gà cũng có cặp chân sù sì, cặp chân gà trống to và bao quanh chân ở phía trước là một lớp vảy da sắp xếp không theo hàng, phần còn lại (3/4 diện tích) da sùi giống bề mặt trái dâu tằm ăn, bốn ngón chân xòe ra, chia ngón rõ nét, bàn chân dày, cân đối nên gà bước đi vững chắc",
ImagePath="Pic2.jpg",
UnitPrice = 431,
CategoryID = 2
},
//chicken 3
new Book
{
BookID = 3,
BookName = "Gà Plymouth",
Description = "Gà được nuôi thuần chủng hoặc lai tạo gà lai nuôi thịt. Gà có tầm vóc lớn, lông trắng trội. Đầu hơi nhỏ so với toàn thân. Mào đơn thẳng, độ lớn trung bình. Tích tai màu đỏ. Cổ và lưng ngắn, ngực sâu, rộng.",
ImagePath ="Pic3.jpg",
UnitPrice = 301,
CategoryID = 2
},
//chicken 4
new Book
{
BookID = 4,
BookName = "Gà nòi",
Description = "Gà nòi là giống gà thuộc nhóm gà trọc đầu. Giống gà này đã được xuất khẩu ra thế giới từ trước thập niên 1990, nhưng chưa được Hoa Kỳ công nhận là một giống gà tiêu chuẩn. Gà nòi là một trong ba giống gà có khả năng chiến đấu của Việt Nam gồm gà nòi, gà tre và gà rừng, trong đó gà nòi và gà tre là giống gà nhà, trong khi gà rừng thuộc loài hoang dã và chỉ chiến đấu trong tự nhiên. Gà nòi có khí chất cương mãnh, dáng vẻ hùng dũng, oai vệ, tính chiến đấu cao và những miếng đánh hiểm hóc, đẹp mắt và là một trong những giống gà tiêu biểu của Việt Nam.",
ImagePath="Pic4.jpg",
UnitPrice = 43,
CategoryID = 4
},
//chicken 5
new Book
{
BookID = 5,
BookName = "Gà Tam hoàng",
Description = " Gà Tam hoàng có bộ lông màu vàng nhạt (màu lông tương đối đồng nhất), chân vàng, mỏ vàng (nên được gọi là gà Tam hoàng), đuôi có lông đen lẫn vào, cơ thể hình tam giác, thân ngắn, lưng bằng, chân ngắn, hai đùi phát triển, chiều cao trung bình, trọng lượng khoảng 2 đến 4 kg (nuôi đến tháng thứ tư), một con gà Trống trưởng thành trung bình nặng từ từ 2,5 – 4 kg, gà Mái trưởng thành năng từ 2 - 2,5 kg, thịt gà vàng và rất chắc thịt.",
ImagePath ="Pic5.jpg",
UnitPrice = 22,
CategoryID = 3
},
//chicken 6
new Book
{
    BookID = 6,
    BookName = "Gà vảy cá",
    Description = "Kiểu lông ngắn và rộng, chóp lông tròn và không nhọn, viền vảy cá sạch, đẹp hơn là lem nhem. Có hai biến thể màu được công nhận ở Bắc Mỹ, màu vàng (golden) và màu trắng (silver). Màu vàng thường phải đậm và đều, trong khi màu trắng phải thực sự trắng. Gà vảy cá nổi tiếng bởi chất lượng của vảy cá tức viền lông. Mỗi sợi lông đều có viền đen, khiến cho màu nền trông sáng và nổi bật hơn.",
    ImagePath ="Pic6.jpg",
    UnitPrice = 215,
    CategoryID = 1
},
//chicken 7
new Book
{
    BookID = 7,
    BookName = "Gà Leghorn",
    Description = "Đối với gà lấy trứng thì có lông và trứng màu trắng, ngoài ra có lông màu nâu, giống gà lông màu trắng tuyền được nuôi rộng rãi hơn gà màu nâu. Mào đơn, tích và dái tai rất phát triển. Mào to, ngả che cả mắt, mào gà mái ngả về một phía gần như che hết cả mắt.",
    ImagePath ="Pic7.jpg",
    UnitPrice = 22,
    CategoryID = 3
},
};
                return books;
            }
        }
}