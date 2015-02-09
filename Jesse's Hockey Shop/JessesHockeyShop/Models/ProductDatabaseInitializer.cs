using System.Collections.Generic;
using System.Data.Entity;

namespace JessesHockeyShop.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseAlways<ProductContext>
  {
    protected override void Seed(ProductContext context)
    {
      GetCategories().ForEach(c => context.Categories.Add(c));
      GetProducts().ForEach(p => context.Products.Add(p));
    }

    private static List<Category> GetCategories()
    {
      var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Skates"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Sticks"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Helmets"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Gloves"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Goalie Gear"
                },
            };

      return categories;
    }

    private static List<Product> GetProducts()
    {
      var products = new List<Product> {

          /////////BEGIN SKATE ENTRIES///////////////
                new Product
                {
                    ProductID = 1,
                    ProductName = "Bauer Nexus Elevate",
                    Description = @"The Nexus Elevate is based off of the Nexus 400 Skate and is a Source for Sports exclusive Special
                    Make-Up Model featuring value added features not seen on the stock 400. The Elevate has an upgraded full composite
                    outsole that provides stability and prevents torsion and twisting. The tongue is made up of a 40 oz. White Felt
                    and has an upgraded metatarsal insert to reduce any lace bite or binding felt. As well as a grey grip liner that
                    locks the foot into the boot and wicks away moisture to keep your feet cool and dry.", 
                    ImagePath="http://i906.photobucket.com/albums/ac268/jessefulcher05/Independent%20Study%20Project/nexusElevate_zpsf39d8789.jpg",
                    UnitPrice = 219.99,
                    CategoryID = 1
               },

               new Product 
                {
                    ProductID = 2,
                    ProductName = "Bauer Supreme One Comp",
                    Description = "The Bauer One.Comp are based off of the Bauer 170 Skates and have upgraded features from the 180 to "
                    + "provide incredible value. Staying with the Supreme fit, the One Comp offers a 3D anatomical fit that provides a "
                    + "tight heel, and slightly wider forefoot to reduce negative volume and lock in the foot.",
                    ImagePath="http://i906.photobucket.com/albums/ac268/jessefulcher05/Independent%20Study%20Project/supremeOneComp_zpsd550de62.jpg",
                    UnitPrice = 399.99,
                    CategoryID = 1
               },

                new Product
                {
                    ProductID = 3,
                    ProductName = "Bauer Vapor X Select",
                    Description = "Based off the Bauer Vapor X60 Skate, the X Select is a Source For Sports exclusive model that features "
                    + "upgrades from the X70 to make it unique. The Beveled Pro-8 TPU outsole has been added from the X70 to provide a more "
                    + "stable skate with less torsion and an upgraded bottom facing adds a custom look. The tongue has also been upgraded to "
                    + "the X70 anatomical 2-piece felt tongue with metatarsal padding to soak up any pressure and reduce pain and binding. As "
                    +"well with an added print to the hydrophobic liner you are sure to stand out.",
                    ImagePath="http://i906.photobucket.com/albums/ac268/jessefulcher05/Independent%20Study%20Project/vaporXselect_zpsfa2ae28e.jpg",
                    UnitPrice = 209.99,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "CCM Legend Tacks",
                    Description = "The CCM Legend Tacks are a Source for Sports special make-up skate based on the Tacks J40 with upgrades taken "
                    + " from the Tacks and Tacks J50 skates. The Internally supported ATTACKFRAME quarter packages uses reinforcements in the heel and"
                    + "eyelet facing to provide support aswell as energy transfer. An upgraded T5-52 Core from the J50 provides a stiff core and performance "
                    + "working alongside the attackframe.",
                    ImagePath="http://i906.photobucket.com/albums/ac268/jessefulcher05/Independent%20Study%20Project/ccmLegendTracks_zpsf28d5191.jpg",
                    UnitPrice = 329.99,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "CCM RBZ Control",
                    Description = "The CCM RBZ Control is based off of the RBZ 100 Skate and has been downgraded in areas to feature some of the RBZ 90 specs. "
                   + " Most Source for Sports SMU models are based off of a lower model and up spec’d for additional value however the Control is the only SMU to" 
                   + " be based off of a higher end model. This allows you to get all or most of the RBZ 100 specs at a fraction of the price. The Control "
                   + " uses the Action Form composite core to provide the quickest most explosive strides, and the Control skates come stock with CCM’s Support insoles to " 
                   + " provide greater stability and overall fit.",
                    ImagePath="http://i906.photobucket.com/albums/ac268/jessefulcher05/Independent%20Study%20Project/ccmRBZcontrol_zpsdf4b3d31.jpg",
                    UnitPrice = 449.95,
                    CategoryID = 1
                },


                ///////////////////////END SKATE ENTRIES////////////////////////////////////////

               ///////////////////////START STICK ENTRIES////////////////////////////////////////
                new Product
                {
                    ProductID = 6,
                    ProductName = "Bauer Nexus 2000 Grip",
                    Description = "One of the better looking sticks made at this price point in a while, the Bauer Nexus 2000 is perfect for someone looking to get into the game. Its fused 2-piece construction gives the stick impressive rigidity when compared to other sticks in the entry level class. If you’re just lacing them up for the first time or you’re playing on a tight budget make sure to include the Bauer Nexus 2000 in your decision making process and come test one out, you won’t be disappointed.",
                    ImagePath="http://i906.photobucket.com/albums/ac268/jessefulcher05/Independent%20Study%20Project/bauernexus2000_zpsaf47fff2.jpg",
                    UnitPrice = 59.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Bauer Nexus 4000 Grip",
                    Description = "While not quite as flashy as its high end counterpart, the Nexus 4000 is still a very capable stick at a very affordable price point. The 4000 features the same mid-kick flex point that the 8000 has and the tacky grip finish allows for maximum control on the powerful shots this stick creates. The aero foam blade core is not quite like the Power Sense blade technology but it still gives the stick a very nice feel when stickhandling or passing the puck around.",
                    ImagePath="http://i906.photobucket.com/albums/ac268/jessefulcher05/Independent%20Study%20Project/bauernexus4000_zpsb7b4e86d.jpg",
                    UnitPrice = 109.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Bauer Nexus 8000 Grip",
                    Description = "Evolving from the Nexus 1000 stick the Nexus 8000 offers similar construction with some significant technological upgrades. Both feature the Nexus exclusive TRU-Mid flex profile, Lightweight TeXteme construction and Monocomp technology throughout the stick. With the addition to the Power SENSE Blade technology the Nexus 8000 is now able to offer increased puck control and shot acceleration. The Nexus Power .520 taper boosts torsional stiffness to maximize loading. This reduces torqueing and twisting for better control and precision. The Bauer Nexus 8000 is offered in both Grip and a Matte finish to customize the fit to suite your game.",
                    ImagePath="http://i906.photobucket.com/albums/ac268/jessefulcher05/Independent%20Study%20Project/bauernexus8000_zps3e9e2ef2.jpg",
                    UnitPrice = 299.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Bauer Supreme TOTALONE NXG",
                    Description = "TotalONE NXG is the 2013 upgrade to the TotalONE. The Dual density blade core should improve balance, power and feel on passing and stick handling while maintaining the torsional stiffness that makes for a hard accurate shot. Another new feature is eLASTech technology which is a proprietary resin system with carbon nanotube reinforcements that increases durability by reducing the spread of micro-fractures that can be the death of a one piece stick. Older features like the Supreme power taper, Pure shot blade profile and TeXtreme are still prevalent in the NXG and at 399 grams it is one of the lightest sticks on the market.",
                    ImagePath="http://i906.photobucket.com/albums/ac268/jessefulcher05/Independent%20Study%20Project/bauerapxNXG_zps93c4e563.jpg",
                    UnitPrice = 59.95,
                    CategoryID = 2
                },

                ////////////end sticks////////////////

                ////////////Start Helmets////////////////
                new Product
                {
                    ProductID = 10,
                    ProductName = "Bauer 2100",
                    Description = "Bauer’s 2100 helmet features a dual-density liner offers great ventilation, while remaining light-weight. The shell design is similar to the one that Bauer uses for the 7500, providing a low profile and comfortable fit. The F.A.S.T adjustment system offers a simple way to adjust the helmet for a secure fit that will fit your needs.",
                    ImagePath="http://i906.photobucket.com/albums/ac268/jessefulcher05/Independent%20Study%20Project/bauer2100_zps30ec4765.jpg",
                    UnitPrice = 44.99,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "Bauer 4500",
                    Description = "Another one of Bauer’s most successful and long lasting model is the 4500. This helmet is one recognized and worn by many at the professional level. It features a dual-density foam liner which is simple, but protective. No fancy features take away from the sleek and simple design. All it takes is a screw-driver to adjust the helmet to find the proper and secure fit. The 4500 remains one of Bauer’s most light-weight models.",
                    ImagePath="http://i906.photobucket.com/albums/ac268/jessefulcher05/Independent%20Study%20Project/bauer4500_zps66e1b0dc.jpg",
                    UnitPrice = 69.00,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "Bauer 9900",
                    Description = "The 9900 helmet from Bauer offers top of the line protection at a valuable price point. After the introduction of the Re-Akt the 9900 was lowered in price, but not in quality! Offering triple-density FXPP comfort cushions, along with an EPP liner and PORON XRD temple padding adds to the superior protection. The tool-free side adjustments make, making any adjustments quick and easy. While the occipital lock 2.0 helps maintain a secure and protective fit. The bio-mechanical shell offers a lower profile fit, making the helmet sleek and aero dynamic. Strategically placed ventilation ports help keep you cool throughout the game. ",
                    ImagePath="http://i906.photobucket.com/albums/ac268/jessefulcher05/Independent%20Study%20Project/bauer9900helmet_zpseb0db6ce.jpg",
                    UnitPrice = 139.99,
                    CategoryID = 3
                },

                ////////////end helmets //////////////////////

                ///////////begin gloves///////////////
                new Product
                {
                    ProductID = 13,
                    ProductName = "Bauer Nexus 800",
                    Description = "The Nexus 800 from Bauer is another model in their traditional wide volume fit family. With an open cuff and loose fit allows for optimal mobility. Comfortable feel inside the glove with a Pro Clarino Ivory mesh Palm and Thermo max+ liner gives you a durable and dry feel anytime you touch the ice. Maximum Protection provided with Dual Density EPP foam to protect against sticks and pucks. Further mobility added with the 2 piece free flex thumb, and a segmented pro style cuff allowing for maximum wrist movement and feel on you stick while keeping you protected. Adding a lightweight and durable Pro Nylon thumb provides a clean look.",
                    ImagePath="http://i906.photobucket.com/albums/ac268/jessefulcher05/Independent%20Study%20Project/bauernexus800gloves_bk_1_zps87202938.jpg",
                    UnitPrice = 129.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 14,
                    ProductName = "Bauer Supreme One Matrix",
                    Description = "Based on the Supreme One.8, The OneMatrix follows the close, natural fit of the TotalOne NXG. With a segmented cuff, back roll and thumb allows natural mobility and feel while keeping elite level protection. Dual Density foams with Poly inserts throughout the glove, with a breathable Pro Nylon outer shell keeping lightweight and high end protection. Moisture wicking Thermo Max+ liner and the addition of the Nubuck Nash Bonded Palm with PU Overlay in heavy stressed areas. The same palm as on the TotalOne NXG, gives you a more durable and better feeling palm at nice price point. Supreme anatomical fit allowing maximum performance.",
                    ImagePath="http://i906.photobucket.com/albums/ac268/jessefulcher05/Independent%20Study%20Project/baueronematrix13gloves_zpsd6e7e621.jpg",
                    UnitPrice = 159.95,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "Bauer Vapor APX2 Pro",
                    Description = "Bauer’s APX2 Pro glove is a unique glove Bauer releases, it is the Standard Vapor fit but the features of the glove are designed from feedback from pro players. The APX2 Pro uses dual density foam with poly inserts throughout the glove for protection along with The PORON XRD foam for extra protection on the back of the hand. As in the APX2 glove, the APX2 Pro has the three piece free flex lock thumb and the three piece index finger for nice mobility and feel. Comfortable and dry feel inside the glove with the use of the Thermo Max liner with the addition of the 37.5 technology which keeps the glove dry as well as assists with the drying process. Ax Suede Quattro+ palm adds a nice comfortable feel on your stick. The glove is finished with 2 pro features, a small pro cuff and a Pro nylon and Cable mesh outer shell to give the glove that light pro feel and look.",
                    ImagePath="http://i906.photobucket.com/albums/ac268/jessefulcher05/Independent%20Study%20Project/bauerapx2proglove_zps85936e52.jpg",
                    UnitPrice = 425.95,
                    CategoryID = 4
                },
                                new Product
                {
                    ProductID = 16,
                    ProductName = "Eagle Talon",
                    Description = "There is a big range of choice when it comes to gloves. The protection level of the glove should match your style of play. We recommend that you get the highest level of protection that you can afford. High density foams and plastic inserts are ideal but those features are usually found on the top level models (there are lots of tiny bones in your hands and you want to make sure that you're not going to be watching from the stands for two months in a cast).",
                    ImagePath="http://i906.photobucket.com/albums/ac268/jessefulcher05/Independent%20Study%20Project/eagleTalon_zpsae9fccf1.jpg",
                    UnitPrice = 125.95,
                    CategoryID = 4
                },

               ///// ///end gloves////////

                /////////begin goalie gear/////
                new Product
                {
                    ProductID = 17,
                    ProductName = "Brians G-NETik Senior Goalie Equipment Combo",
                    Description = "G-NETik offers both smart straps and traditional leather strapping that are removable and/or replaceable allowing the goalie the ultimate opportunity to customize strapping with both style and placemen",
                    ImagePath="http://i906.photobucket.com/albums/ac268/jessefulcher05/Independent%20Study%20Project/briansg-netik_combo_zpsedfabcc7.jpg",
                    UnitPrice = 1728.99,
                    CategoryID = 5
                },

                new Product
                {
                    ProductID = 18,
                    ProductName = "Vaughn Ventus LT80 Senior Goalie Equipment Combo",
                    Description = "Since 1982 Vaughn Custom Sports has been in the forefront of goaltending equipment design at both the retail and pro level. Vaughn specializes in detailed colour schemes and custom modifications built out of their factories located in London, Ontario and Oxford, Michigan. They are commonly credited with creating the first “butterfly” pad – the Vaughn Velocity. Over the years their products have been used by pros like Kirk Maclean, Carey Price, and Stanley Cup Champions Tim Thomas and Cam Ward.",
                    ImagePath="http://i906.photobucket.com/albums/ac268/jessefulcher05/Independent%20Study%20Project/vaughnlt80_combo_zpsade2cff5.jpg",
                    UnitPrice = 2222.95,
                    CategoryID = 5
                }
            };

      return products;
    }
  }
}