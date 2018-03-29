//Tính giá tiền từng cái orderDetail 
use CameraShop
Select OrderListID, o.CameraID,Quantity, CameraName, Price , Tong = Price*Quantity
From tblOrderDetail o, tblCamera c 
Where OrderListID = 'OrderList5' and o.CameraID = c.CameraID

//Tính giá tiền của 1 cái orderListID
Select OrderListID, Tong = sum(Price*Quantity)
From tblOrderDetail o, tblCamera c 
Where OrderListID = 'OrderList5' and o.CameraID = c.CameraID
group by OrderListID

//Tính Tổng tiền của 1 bảng orderlistID

Select l.OrderListID, Tong = sum(Price*Quantity)
From tblOrderDetail o, tblCamera c, tblOrderList l
Where l.OrderListID = o.OrderListID and o.CameraID = c.CameraID 
group by l.OrderListID

//Giao diện quản lấy thấy 
Select o.OrderListID,o.CustomerID,o.[Date],o.UsernameID,t.Tong
From tblOrderList o, (Select l.OrderListID, Tong = sum(Price*Quantity)
					From tblOrderDetail o, tblCamera c, tblOrderList l
					Where l.OrderListID = o.OrderListID and o.CameraID = c.CameraID 
					group by l.OrderListID) t
Where o.OrderListID = t.OrderListID

//Giao diện cuối cùng mong muốn
Select ox.OrderListID,ox.CustomerID,ox.[Date],ox.UsernameID,t.Tong
from tblOrderList ox , (Select l.OrderListID, Tong = sum(Price*Quantity)
					From tblOrderDetail o, tblCamera c, tblOrderList l
					Where l.OrderListID = o.OrderListID and o.CameraID = c.CameraID 
					group by l.OrderListID) t
where Date >= '10-22-2017' and Date <= '10-23-2017' and ox.OrderListID = t.OrderListID

//Tính tổng tất cả các hóa đơn

Select Tong = sum(t.Tong)
from tblOrderList ox , (Select l.OrderListID, Tong = sum(Price*Quantity)
					From tblOrderDetail o, tblCamera c, tblOrderList l
					Where l.OrderListID = o.OrderListID and o.CameraID = c.CameraID 
					group by l.OrderListID) t
where Date >= '10-22-2017' and Date <= '10-23-2017' and ox.OrderListID = t.OrderListID

//Thong ke mat hang
Select a.OrderListID, a.CustomerID , a.[Date] , a.UsernameID , b.CameraID , b.Quantity , c.Price , Tong = b.Quantity*c.Price, b.Note 
From tblOrderList a,tblOrderDetail b , tblCamera c
Where a.OrderListID = b.OrderListID and b.CameraID = 'Cam5'and c.CameraID = b.CameraID



Select ox.OrderListID,ox.CustomerID,ox.[Date],ox.UsernameID,t.Tong
from tblOrderList ox , (Select l.OrderListID, Tong = sum(Price*Quantity)
					From tblOrderDetail o, tblCamera c, tblOrderList l
					Where l.OrderListID = o.OrderListID and o.CameraID = c.CameraID 
					group by l.OrderListID) t
where Date >= '10-22-2017' and Date <= '10-23-2017' and ox.OrderListID = t.OrderListID

//Tong so hoa don
Select *
From tblOrderList

//San pham ban chay nhat
Select t.CameraID, c.CameraName , t.Tong
From tblCamera c, (Select c.CameraID, Tong = sum(b.Quantity*c.Price)
					From tblOrderList a,tblOrderDetail b , tblCamera c
					Where a.OrderListID = b.OrderListID and c.CameraID = b.CameraID
					Group By c.CameraID ) t
Where c.CameraID = t.CameraID

//Khach Hang mua hang nhieu nhat
Select c.CustomerID , c.CustomerName , t.Tong
From tblCustomer c , (Select cus.CustomerID,Tong = sum(b.Quantity*cam.Price)
					From tblOrderList a , tblOrderDetail b , tblCamera cam , tblCustomer cus
					Where cus.CustomerID = a.CustomerID and a.OrderListID = b.OrderListID and cam.CameraID = b.CameraID
					Group By cus.CustomerID) t
Where c.CustomerID = t.CustomerID

//Tong So luong hoa don , va Tong tien thu ve
Select ox.OrderListID,ox.CustomerID,ox.[Date],ox.UsernameID,t.Tong
from tblOrderList ox , (Select l.OrderListID, Tong = sum(Price*Quantity)
					From tblOrderDetail o, tblCamera c, tblOrderList l
					Where l.OrderListID = o.OrderListID and o.CameraID = c.CameraID 
					group by l.OrderListID) t
where ox.OrderListID = t.OrderListID









