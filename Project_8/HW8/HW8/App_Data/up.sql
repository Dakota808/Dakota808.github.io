Create Table [dbo].[Buyers](
 BuyerID int identity (1,1) not null Primary Key,
 BuyersName varchar(50) not  null
);

Create Table [dbo].[Sellers](
 SellerID int identity (1,1) not null Primary Key,
 SellersName varchar (50) not null
);

Create Table [dbo].[Items](
 ItemID int identity (1001,1) not null Primary Key,
 Seller int Foreign Key References Sellers(SellerID),
 ItemName varchar (255) not null, 
 ItemDescription varchar (255) not null
);

Create Table [dbo].[Bids](
 BidID int identity (1,1) not null Primary Key, 
 Item int Foreign Key References Items (ItemID),
 Bider int Foreign Key References Buyers (BuyerID),
 TimeStamps Datetime not null,
 Prices int not null
);

Insert into Buyers(BuyersName)
 Values
  ('Jane Stone'),
  ('Tom McMaster'),
  ('Otto VanderWall');

Insert into Sellers(SellersName)
 Values
 ('Gayle Hardy'),
 ('Lyle Banks'),
 ('Pearl Greene');

 Insert into Items(ItemName, ItemDescription, Seller)
  Values
  ('Abraham Lincoln Hammer', 'A bench mallet from a broken rail-splitting maul in 1829 and owned by Abraham Lincoln', 3),
  ('Albert Einstiens Telescope', 'A brass telescope owned by Albert Einstein in Germany, Circa 1927', 1),
  ('Bob Dylan Love Poems', 'Five versions of an original unpublished, handwritten, love poem by Bob Dylan', 2);

Insert into Bids(Item, Bider, Prices, TimeStamps)
 Values
 (1001,3, 250000, '12/02/2018 09:04:22'),
 (1003, 1, 95000, '11/24/2018 08:44:03'),
 (1002, 2, 100000, '11/18/2018 10:24:32');