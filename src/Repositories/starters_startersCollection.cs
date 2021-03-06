// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   DataSource.tt
using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using Entities=WPAppStudio.Entities;
using RepositoriesBase=WPAppStudio.Repositories.Base;
using WPAppStudio.Shared;

namespace WPAppStudio.Repositories
{
    /// <summary>
    /// starters_startersCollection data source.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public class starters_startersCollection : Istarters_startersCollection 
    {
		private const int MaxResults = 10;
        private readonly ObservableCollection<Entities.startersSchema> _data = new ObservableCollection<Entities.startersSchema>
		{
          new Entities.startersSchema
            {
                Id= new Guid("4ecaf669-c22a-4205-a3ca-04889f63cfc3"),
                Subtitle=@" Nem หรือ เปาะเปี๊ยะเวียดนาม",
                Title=@"เวียดนาม (Vietnam)",
                Image=@"\Images\Item-50909b57-c8ab-49d8-a589-15f5803edde2.jpg",
                Description=@"แหนม หรือ ปอเปี๊ยะเวียดนาม เป็นอาหารยอดนิยมของเวียดนาม หนึ่งในอาหารพื้นเมืองที่โด่งดังที่สุด

            ของประเทศแผ่นแป้งทำจากข้าวจ้าว นำมาห่อไส้  ซึ่งอาจเป็นไก่ หมู กุ้ง หรือหมูยอ รวมกับผักที่มีสรรพคุณ
 เป็นยานานาชนิด เช่น สะระแหน่  ผักกาดหอม ทานคู่กับน้ำจิ้มหวาน",
			},
          new Entities.startersSchema
            {
                Id= new Guid("9a753f43-1d95-4aa8-9500-178d6485e52f"),
                Subtitle=@" กาโด กาโด (Gado Gado)",
                Title=@"อินโดนีเซีย (Indonesia)",
                Image=@"\Images\Item-2376f5a8-45b4-4586-beb8-25b256d72afb.jpg",
                Description=@"กาโด กาโด (Gado Gado) เป็นหนึ่งในอาหารยอดนิยมของอินโดนีเซียคล้ายกับสลัดแขกซึ่งจะประกอบด้วย ถั่วเขียว มันฝรั่ง ถั่งงอก เต้าหู้ ไข่ต้มสุก กะหล่ำปลี ข้าวเกรียบกุ้ง รับประทานกับซอสถั่วที่มีลักษณะเหมือนซอสสะเต๊ะ",
			},
          new Entities.startersSchema
            {
                Id= new Guid("04e54c56-c010-4367-aa8a-9ad84fdda953"),
                Subtitle=@" ซุบไก่ (Chicken Soup)",
                Title=@"ลาว (Loas)",
                Image=@"\Images\Item-db1613de-ecb5-4d25-8331-3de4277aae09.jpg",
                Description=@"ซุปไก่ (Chicken Soup) เป็นหนึ่งในอาหารพื้นเมืองของประเทศลาว มีส่วนผสมในการประกอบอาหารคือ ตะไคร้ ใบสะระแหน่ กระเทียม และหอมแดง ทั้งนี้ อาหารลาวโดยส่วนใหญ่มักจะมีผักและสมุนไพรเป็นส่วนผสมในการปรุงรส",
			},
          new Entities.startersSchema
            {
                Id= new Guid("6dd9d3c6-69e6-4d0d-a444-8c79e30bfe59"),
                Subtitle=@" ต้มยำกุ้ง (Tom Yam Goong)",
                Title=@"ประเทศไทย (Thailand)",
                Image=@"\Images\Item-f25d9eef-024a-45d3-9c19-b200f81d0389.jpg",
                Description=@"ต้มยำเป็นอาหารพื้นเมืองที่คนไทยคุ้นเคยดี เพราะมีให้รับประทานทุกภาคและเป็นที่นิยมสำหรับชาวต่างชาติด้วย หนึ่งในเมนูต้มยำที่มีชื่อเสียงระดับโลก คือต้มยำกุ้ง ต้มยำเป็นอาหารที่ครบรส คือ เปรี้ยว เค็ม เผ็ด หวานเล็กน้อย ",
			},
          new Entities.startersSchema
            {
                Id= new Guid("e26e8d42-ba7e-468e-bc6d-e79ee8a0c767"),
                Subtitle=@" นาซิ เลอมัก (Nasi Lemak)",
                Title=@"มาเลเซีย (Malaysia)",
                Image=@"\Images\Item-9249f245-5a4f-4482-9909-72022af2c757.jpg",
                Description=@"นาซิ เลอมัก (Nasi Lemak) อาหารยอดนิยมของมาเลเซีย คือข้าวหุงกับกะทิและใบเตย ทานพร้อม เครื่องเคียง 4 อย่างได้แก่ ปลากะตักทอดกรอบ แตงกวาหั่น ไข่ต้มสุก และถั่วอบ นาซิ เลอมักแบบดั้งเดิมจะห่อด้วยใบตองและมักทานเป็นอาหารเช้า แต่ในปัจจุบัน กลายเป็นอาหารยอดนิยมที่ทานได้ทุกมื้อ และแพร่หลาย ในประเทศเพื่อนบ้านอีกหลายแห่ง เช่น สิงคโปร์ และภาคใต้ของไทย",
			},
          new Entities.startersSchema
            {
                Id= new Guid("7da772dd-7a7c-4b87-b0c4-7e6e1d3db561"),
                Subtitle=@" หล่าเพ็ด (Lahpet)",
                Title=@"พม่า (Myanmar)",
                Image=@"\Images\Item-0cc5c35e-8d71-4f43-ad89-565dde15d6da.jpg",
                Description=@"หล่าเพ็ด (Lahpet) เป็นอาหารประจำชาติของพม่าที่มีลักษณะคล้ายกับยำเมี่ยงของไทยโดยรับประทานกับเครื่องเคียง เช่น ใบชาหมัก กระเทียมเจียว ถั่วชนิดต่างๆ งาคั่ว กุ้งแห้ง ขิง มะพร้าวคั่ว เป็นต้น โดยในเทศกาลสำคัญต่างๆ ของพม่าจะมีอาหารยอดนิยมจานนี้เป็นหลัก",
			},
          new Entities.startersSchema
            {
                Id= new Guid("b9338c78-4391-432e-a52f-7b9e42b0cb16"),
                Subtitle=@"ลักสา (Laksa) เป็นก๋วยเตี๋ยวต้มยำ (ใส่กะทิ)",
                Title=@"สิงคโปร์ (Singapore) ",
                Image=@"\Images\Item-bb044d5b-fb41-4794-86b4-328ff14af47e.jpg",
                Description=@"ลักซา (Laksa)อาหารขึ้นชื่อของประเทศสิงคโปร์ ลักซามีลักษณะคล้ายก๋วยเตี๋ยวต้มยำใส่กะทิทำให้รสชาติเข้มข้น คล้ายคลึงกับข้าวซอยของไทย โดยลักซาจะมีส่วนผสมของ กุ้งแห้งพริก กุ้งต้ม และหอยแครง เหมาะสำหรับคนที่ชอบรับประทานอาหารทะเลเป็นอย่างยิ่งอย่างไรก็ตาม ลักซามีทั้งแบบที่ใส่กะทิ และไม่ใส่กะทิ ทว่าแบบที่ใส่กะทิจะเป็นที่นิยมมากกว่า",
			},
          new Entities.startersSchema
            {
                Id= new Guid("a63c73ec-e1a3-4056-a0b0-f998ddb7fcd4"),
                Subtitle=@"อโดโบ้ (Adobo)",
                Title=@"ฟิลิปปินส์ (Philippines)",
                Image=@"\Images\Item-068571fb-af95-45f7-a678-880342f3d4b6.jpg",
                Description=@" อะโดโบ (Adobo) เป็นอาหารฟิลิปปินส์ที่ได้รับความนิยมปรุงจากเนื้อสัตว์หรืออาหารทะเลหมักด้วยน้ำส้มสายชูและกระเทียม ทอดในน้ำมันจนเป็นสีน้ำตาล คำว่า ""อะโดโบ"" มาจากภาษาสเปน แต่วิธีการทำอาหารเป็นของชนพื้นเมืองชาวฟิลิปปินส์ เมื่อสเปนเอาชนะฟิลิปปินส์ในช่วงปลายคริสต์ศตวรรษที่ 16 และต้นคริสต์ศตวรรษที่ 17 ชาวสเปนจึงรู้จักขั้นตอนการทำอาหารพื้นเมืองที่เกี่ยวข้องกับน้ำส้มสายชูซึ่งเรียกว่า  อะโดโบ ซึ่งเป็นภาษาสเปนหมายถึงการปรุงรสหรือหมัก ",
			},
          new Entities.startersSchema
            {
                Id= new Guid("c5478f82-b658-412c-ad6d-6868effc4359"),
                Subtitle=@"อัมบูยัต (Ambuyat)",
                Title=@"บรูไน ดารุสซาลาม (Brunei Darussalam)",
                Image=@"\Images\Item-f651d552-7c6e-427f-98cc-e956591fb05a.jpg",
                Description=@"อัมบูยัต (Ambuyat) จัดเป็นอาหารประจำชาติที่มีชื่อเสียงที่สุดของบรูไน ดารุสซาลาม มีลักษณะคล้ายกับข้าวต้มหรือโจ๊ก มีส่วนผสมของแป้งสาคูเป็นหลัก โดยทั่วไปอัมบูยัต คือ อาหารที่รับประทานแทนข้าว โดยจะมีอาหารจานหลักและเครื่องเคียงอย่างน้อย 3 อย่าง วางอยู่โดยรอบ",
			},
          new Entities.startersSchema
            {
                Id= new Guid("8df69c13-f893-4633-8781-1152c290113a"),
                Subtitle=@"อาม็อก (Amok)",
                Title=@"กัมพูชา (Cambodia)",
                Image=@"\Images\Item-ba45694b-f0c9-48cd-89d3-87b73d023945.jpg",
                Description=@"อาม็อก (amok) มีลักษณะคล้ายห่อหมกของไทย ทำจากปลา น้ำพริก เครื่องแกงและกะทิ อาม็อก เป็นหนึ่งในอาหารยอดนิยมของกัมพูชา",
			},
		};
	
		
        /// <summary>
        /// Retrieves the data from a static data source, in an observable collection of startersSchema items.
        /// </summary>
        /// <returns>An observable collection of startersSchema items.</returns>
        public ObservableCollection<Entities.startersSchema> GetData(int numPage)
        {								
			return new ObservableCollection<Entities.startersSchema>(_data.Skip(MaxResults * numPage).Take(MaxResults));
        }
		
		/// <summary>
        /// Retrieves the data from a static data source, filtered by a filter specification, in an observable collection of startersSchema items.
        /// </summary>
		/// <param name="filter">Filter operation specification</param>
        /// <returns>An observable collection of startersSchema items.</returns>
        public ObservableCollection<Entities.startersSchema> Search(FilterSpecification filter)
        {
            return RepositoriesBase.Filter<Entities.startersSchema>.FilterCollection(filter, _data);
        }
		
		/// <summary>
        /// Checks if data source has a element before the passed as parameter
        /// </summary>
		/// <param name="current">Current element</param>
        /// <returns>True, if there is a previous element, false if there is not</returns>
		public bool HasPrevious(Entities.startersSchema current)
        {
            if (current == null || !_data.Any()) return false;

            return _data.IndexOf(current) > 0;
        }
		
		/// <summary>
        /// Checks if data source has a element after the passed as parameter
        /// </summary>
		/// <param name="current">Current element</param>
        /// <returns>True, if there is a next element, false if there is not</returns>
		public bool HasNext(Entities.startersSchema current)
        {
            if (current == null || !_data.Any()) return false;

            return _data.IndexOf(current) < _data.Count - 1;
        }
		
		/// <summary>
        /// Retrieves the previous element from source.
        /// </summary>
		/// <param name="current">Current element</param>
        /// <returns>The previous element from items, if it exists. Otherwise, returns null</returns>
        public Entities.startersSchema Previous(Entities.startersSchema current)
        {
            if (current == null || !_data.Any()) return null;

            if (_data.First().Equals(current)) return null;

            return _data[_data.IndexOf(current) - 1];
        }
		
		/// <summary>
        /// Retrieves the next element from source.
        /// </summary>
		/// <param name="current">Current element</param>
        /// <returns>The next element from items, if it exists. Otherwise, returns null</returns>
        public Entities.startersSchema Next(Entities.startersSchema current)
        {
            if (current == null || !_data.Any()) return null;

            if (_data.Last().Equals(current)) return null;

            return _data[_data.IndexOf(current) + 1];
        }
	}
}

