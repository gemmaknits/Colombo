# คู่มือการใช้งานระบบ Sales Order System (Eschler)

## 1. ภาพรวมระบบ

Sales Order System (Eschler) เป็นโปรแกรมสำหรับบันทึกและติดตามงานขาย ตั้งแต่การจัดการข้อมูลพื้นฐาน, เปิด Sales Order, พิมพ์เอกสาร, ติดตามสถานะ Order, ออก Invoice, จัดการ Stock/Packing และเรียกรายงานที่เกี่ยวข้อง

คู่มือนี้จัดทำสำหรับผู้ใช้งานทั่วไป โดยเน้นขั้นตอนการใช้งานหน้าจอและเมนูหลักของระบบ ไม่ครอบคลุมการตั้งค่าฐานข้อมูลหรือการแก้ไขโปรแกรม

## 2. การเข้าใช้งานระบบ

1. เปิดโปรแกรม `Sales Order System (Eschler)`
2. ที่หน้าจอ `SALE ORDER LOGIN` ให้เลือกข้อมูลดังนี้
   - `Database`: เลือกฐานข้อมูลที่ต้องการใช้งาน
   - `Warehouse`: เลือกคลังสินค้าที่ใช้งาน
   - `User name`: กรอกชื่อผู้ใช้
   - `Password`: กรอกรหัสผ่าน
3. กดปุ่ม `Login`
4. หากต้องการออกจากหน้าจอ Login ให้กด `Exit`

หมายเหตุ:

- หากชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง ระบบจะแจ้ง `Incorrect username or password`
- หากระบบเชื่อมต่อ Server ไม่ได้ ให้แจ้งผู้ดูแลระบบ
- เมนูที่มองเห็นได้อาจแตกต่างกันตามสิทธิ์ของผู้ใช้แต่ละคน

## 3. การเปลี่ยนรหัสผ่าน

สามารถเปลี่ยนรหัสผ่านได้ 2 วิธี

วิธีที่ 1: จากหน้าจอ Login

1. กรอก `User name` และ `Password` ปัจจุบัน
2. ติ๊ก `Change Password`
3. กรอก `New Password`
4. กรอก `Confirm Password`
5. กด `Change Password`
6. เมื่อระบบแจ้งเปลี่ยนรหัสผ่านสำเร็จ ระบบจะเข้าสู่โปรแกรมต่อ

วิธีที่ 2: จากเมนูหลัก

1. ไปที่เมนู `Windows > Change Password`
2. กรอกรหัสผ่านใหม่ตามหน้าจอ
3. บันทึกการเปลี่ยนแปลง

ข้อควรระวัง:

- `New Password` และ `Confirm Password` ต้องตรงกัน
- ไม่ควรใช้รหัสผ่านเดิมซ้ำ
- หากรหัสผ่านหมดอายุ ระบบจะบังคับให้เปลี่ยนรหัสผ่านก่อนเข้าใช้งาน

## 4. ส่วนประกอบของหน้าจอหลัก

หลังจาก Login สำเร็จ ระบบจะแสดงหน้าจอหลักพร้อมแถบเมนูด้านบน โดยมีข้อมูลสำคัญดังนี้

- เมนูหลักสำหรับเปิดหน้าจอทำงานแต่ละส่วน
- สถานะ `Connection` แสดง Server ที่เชื่อมต่ออยู่
- ค่า `Exchange Rate USD/THB`
- ชื่อฐานข้อมูลที่ใช้งาน
- พื้นที่ทำงานแบบหลายหน้าต่าง ผู้ใช้สามารถเปิดหลายหน้าจอพร้อมกันได้

## 5. ปุ่มที่พบบ่อยในระบบ

| ปุ่ม | ความหมาย |
| --- | --- |
| `Search` | ค้นหาเอกสารหรือข้อมูลเดิม |
| `New` | สร้างเอกสารใหม่ |
| `Copy` | คัดลอกข้อมูลจากเอกสารเดิม |
| `Save` | บันทึกข้อมูล |
| `Print` | พิมพ์เอกสารหรือเปิดรายงาน |
| `Cancel` | ยกเลิกเอกสารหรือรายการ |
| `Confirm` | ยืนยัน Order |
| `Unconfirm` | ยกเลิกการยืนยัน Order |
| `Minimized` | ย่อหน้าต่าง |
| `Exit` | ปิดหน้าจอปัจจุบัน |

## 6. เมนู Master

ใช้จัดการข้อมูลพื้นฐานที่นำไปใช้ในเอกสารต่าง ๆ

เมนูหลัก:

- `Master > Customer`: ข้อมูลลูกค้า
- `Master > Customer Items`: รายการสินค้า/Item ของลูกค้า
- `Master > Agency`: ข้อมูล Agency
- `Master > Supplier`: ข้อมูล Supplier
- `Master > End Buyer`: ข้อมูลผู้ซื้อปลายทาง
- `Master > Color`: ข้อมูลสี
- `Master > Design Master New`: ข้อมูล Design
- `Master > Mould`: ข้อมูล Mould
- `Master > Composition Group`: กลุ่ม Composition
- `Master > Locations`: ข้อมูล Location

แนวทางการใช้งาน:

1. เปิดเมนู Master ที่ต้องการ
2. กด `Search` เพื่อตรวจสอบว่ามีข้อมูลเดิมอยู่หรือไม่
3. หากไม่มีข้อมูล ให้กด `New`
4. กรอกข้อมูลตามช่องที่ระบบกำหนด
5. กด `Save`

ข้อควรระวัง:

- ควรตรวจสอบข้อมูลซ้ำก่อนสร้างใหม่
- ข้อมูล Master มีผลต่อเอกสารและรายงานหลายส่วน

## 7. การใช้งาน Sales Order

เมนู Sales Order ใช้สร้าง แก้ไข พิมพ์ ปิด และติดตามใบสั่งขาย

เมนูที่เกี่ยวข้อง:

- `Sales Order > Edit Sales Order`
- `Sales Order > Print Sales Order`
- `Sales Order > Close Sales Order`
- `Sales Order > Close Sales Order By PO`
- `Sales Order > Close ST Order`
- `Sales Order > Quotation`
- `Sales Order > PDR`

### 7.1 สร้าง Sales Order ใหม่

1. ไปที่ `Sales Order > Edit Sales Order`
2. กด `New`
3. กรอกข้อมูลส่วนหัวของ Sales Order เช่น
   - `S/O Date`
   - `Customer Bill To`
   - `Delivery To`
   - `Agency`
   - `Sales person (C/S)`
   - `Customer P/O`
   - `Payment terms`
   - `Delivery Terms`
4. เลือกประเภท Order ในส่วน `Order type` เช่น
   - `Export Order`
   - `Stock order`
   - `Sample order`
   - `Program Order`
   - `Clearance order`
5. ไปที่แท็บ `Order Items`
6. เพิ่มรายการสินค้า, Design, สี, จำนวน และข้อมูลที่เกี่ยวข้อง
7. ตรวจสอบยอด `Net S/O Amount`
8. กด `Save`
9. เมื่อตรวจสอบข้อมูลถูกต้องแล้ว กด `Confirm`

หมายเหตุ:

- ระบบมีข้อความเตือนว่า `Only 'ENT' Status can edit Qty` หมายถึงแก้ไขจำนวนได้เฉพาะ Order ที่ยังอยู่สถานะ `ENT`
- `S/O No.`, Item Amount และ Net Item Amount จะคำนวณโดยระบบ

### 7.2 ค้นหาและแก้ไข Sales Order

1. ไปที่ `Sales Order > Edit Sales Order`
2. กด `Search`
3. เลือก Sales Order ที่ต้องการ
4. แก้ไขข้อมูลที่อนุญาตให้แก้ไข
5. กด `Save`

ข้อควรระวัง:

- Order ที่ Confirm แล้วอาจแก้ไขข้อมูลบางส่วนไม่ได้
- หากต้องแก้จำนวนหรือข้อมูลสำคัญ ให้ตรวจสอบสถานะ Order ก่อน

### 7.3 พิมพ์ Sales Order

1. เปิด Sales Order ที่ต้องการ หรือไปที่ `Sales Order > Print Sales Order`
2. เลือกเอกสารจากปุ่ม `Print`
   - `Print SO`
   - `Print QSR`
   - `Print Proforma Invoice`
3. ตรวจสอบตัวอย่างเอกสารก่อนพิมพ์หรือส่งออก

### 7.4 ปิด Sales Order

1. ไปที่ `Sales Order > Close Sales Order`
2. ค้นหา Sales Order ที่ต้องการปิด
3. ตรวจสอบสถานะการส่งของและ Invoice
4. ดำเนินการปิด Order ตามเงื่อนไขของหน่วยงาน

## 8. รายงาน Sales Order

รายงานอยู่ที่ `Sales Order > Report`

รายงานที่ใช้บ่อย:

| รายงาน | ใช้สำหรับ |
| --- | --- |
| `S/O & Inv. Control Sheet` | ตรวจสอบความสัมพันธ์ระหว่าง Sales Order และ Invoice |
| `S/O Monthly` | สรุปยอด Sales Order รายเดือน |
| `S/O Delivery Schedule` | ดูตารางส่งสินค้า |
| `S/O Delivery Plan` | ดูแผนการส่งสินค้า |
| `S/O Status By Customer` | ตรวจสอบสถานะ Order แยกตามลูกค้า |
| `S/O Status By Agency` | ตรวจสอบสถานะ Order แยกตาม Agency |
| `S/O Status By Employee` | ตรวจสอบสถานะ Order แยกตามพนักงาน |
| `S/O Summary` | สรุปภาพรวม Sales Order |
| `S/O Trace Report` | ติดตามเส้นทาง/สถานะของ Order |
| `Sales Performance` | ดูผลการขาย |
| `Price History` | ตรวจสอบประวัติราคา |
| `S/O Calendar` | ดูข้อมูล Order ในรูปแบบปฏิทิน |
| `S/O Not Closed (Pending)` | ตรวจสอบ Order ที่ยังไม่ปิด |
| `S/O Book Shipment` | รายงานยอด Book, Invoice และ Pending Shipment |

วิธีใช้งานรายงานทั่วไป:

1. เปิดรายงานที่ต้องการ
2. กำหนดช่วงวันที่หรือเงื่อนไข เช่น Customer, S/O No., Invoice No.
3. กด `Print` หรือปุ่มแสดงรายงาน
4. ตรวจสอบผลลัพธ์
5. หากรายงานใช้เวลานาน ให้รอจนระบบประมวลผลเสร็จ

## 9. การใช้งาน D/F Order

เมนู D/F Order ใช้จัดการงานย้อมและรายงานที่เกี่ยวข้อง

เมนูหลัก:

- `D/F Order > Edit Dying Order (New)`
- `D/F Order > Print Dying Order`
- `D/F Order > Change D/F S/O`
- `D/F Order > D/F Bulk Approve`
- `D/F Order > Close Dying Order`
- `D/F Order > Scrap Return`
- `D/F Order > Other Reports`

รายงานที่เกี่ยวข้อง:

- `D/F Order Search`
- `Dying Order Summary`
- `D/F Weight Control 2`
- `D/F Order Pending`
- `D/F Order Search Design`
- `Check KO-Yarn`
- `D/F Order Closing`
- `D/F Order Evaluation`
- `D/F Order Invoice Control`
- `Stock Sample Aging`

แนวทางการใช้งาน:

1. เปิดเมนู D/F Order ที่ต้องการ
2. ค้นหา Sales Order หรือ D/F No.
3. ตรวจสอบ Design, สี, จำนวน และสถานะงาน
4. บันทึกหรือพิมพ์เอกสารตามขั้นตอนของแผนก

## 10. การใช้งาน Lab Test

เมนู Lab Test ใช้จัดการและพิมพ์ข้อมูล Lab

เมนูหลัก:

- `Lab Test > Edit Lab`
- `Lab Test > Print Lab`
- `Lab Test > Others > Pending`

แนวทางการใช้งาน:

1. เปิด `Edit Lab`
2. ค้นหาหรือสร้างรายการ Lab
3. กรอกข้อมูลสี, ลูกค้า, Design และรายละเอียดการทดสอบ
4. บันทึกข้อมูล
5. ใช้ `Print Lab` เพื่อพิมพ์เอกสาร
6. ใช้ `Pending` เพื่อติดตามงาน Lab ที่ยังค้างอยู่

## 11. การใช้งาน Request

เมนู Request ใช้สร้างคำขอเบิกหรือเคลื่อนย้าย Stock

เมนูหลัก:

- `Request > Stock Greige`
- `Request > Stock Dyed`
- `Request > Stock Sample`

แนวทางการใช้งาน:

1. เลือกประเภท Stock ที่ต้องการ Request
2. กรอกข้อมูลเอกสารและรายการสินค้า
3. ตรวจสอบจำนวนและหน่วย
4. บันทึกเอกสาร
5. ส่งต่อให้หน่วยงาน Stock หรือ Packing ดำเนินการ

## 12. การใช้งาน Invoice

เมนู Invoice ใช้พิมพ์และตรวจสอบ Invoice

เมนูหลัก:

- `Invoice > Local Invoice`
- `Invoice > Export Invoice`
- `Invoice > Reports`

### 12.1 พิมพ์ Local Invoice

1. ไปที่ `Invoice > Local Invoice > Print`
2. กำหนดเงื่อนไข เช่น
   - `Invoice No.`
   - `Invoice Date From`
   - `To`
   - `Customer Name`
   - `Language`: `English` หรือ `Thai`
3. กด `Print`
4. รอระบบประมวลผลและตรวจสอบตัวอย่างเอกสาร

หมายเหตุ: หน้ารายงานบางส่วนอาจใช้เวลาประมวลผลนาน ควรรอจนกว่าระบบจะแสดงผลครบ

### 12.2 ตรวจสอบ Invoice

ใช้รายงานกลุ่ม `Invoice > Reports` เช่น `Invoice Year Summary` เพื่อตรวจสอบยอดรายปีหรือภาพรวม Invoice

## 13. การใช้งาน Stock

เมนู Stock ใช้บันทึกรับเข้า จ่ายออก พิมพ์เอกสาร/Tag และตรวจสอบ Stock

กลุ่มเมนูหลัก:

- `Stock > Dyed`
- `Stock > Greige`
- `Stock > Cutting`
- `Stock > Sample`
- `Stock > Hanger`
- `Stock > Ending Inventory`
- `Stock > Report`
- `Stock > Transfer Location And Grade`

### 13.1 Dyed Stock

เมนูที่ใช้บ่อย:

- `DIN (Gamma)`
- `DIN Manual`
- `DIN Purchase`
- `DIN Return`
- `DIN Location (Edit QC Remark)`

ตัวอย่างหน้าจอ `D-IN Manual` มีปุ่มหลัก:

- `New`: สร้าง D-IN ใหม่
- `Save`: บันทึก
- `Print > D-IN Document`: พิมพ์เอกสาร D-IN
- `Print > D-IN Tag`: พิมพ์ Tag
- `Cancel`: ยกเลิก
- `Exit`: ออกหน้าจอ

ข้อมูลที่ต้องตรวจสอบ:

- `DIN No.`
- `DIN Date`
- `DF No.`
- `Lot No.`
- `Bill No.`
- `Yds`, `Mts`, `Kgs`, `Rolls`
- `Remark`

### 13.2 Greige Stock

เมนูที่ใช้บ่อย:

- `GIN PFD (Gamma)`
- `GIN PFD Manual`
- `GIN Purchase`
- `GIN Return`
- `GIN (Edit QC Remark)`

ใช้สำหรับบันทึกรับเข้า Greige, พิมพ์เอกสาร G-IN และพิมพ์ Tag

### 13.3 Sample และ Hanger

Sample:

- `Dyed Out Sample (PLS)`
- `Dyed Out Barcode`
- `Sample IN (From Greige Out)`
- `Sample Tag`

Hanger:

- `Hanger In Barcode`
- `Hanger Out Barcode`
- `Hanger Return Barcode`

## 14. Stock Report

เมนู `Stock Report` ใช้เรียกรายงานและเอกสาร Stock

เมนูที่ใช้บ่อย:

- `Greige Out From D/F`
- `Greige Out From Request`
- `Greige Out Change Design`
- `Greige Out Manual (No D/F)`
- `Dyed Out From Request(Sample)`
- `Print Greige IN`
- `Print D-IN`
- `Stock Onhand`
- `Barcode`
- `Reports`

รายงาน Stock Onhand:

- `Stock Onhand`
- `Greige Onhand`
- `Greige Onhand By Design`
- `Greige Onhand by Location`
- `Greige Onhand Movement Status`
- `Greige Onhand Summary`
- `Greige Onhand Aging`
- `Cutted Onhand`
- `Stock Onhand Summary For Year`

## 15. การใช้งาน Packing

เมนู Packing ใช้ทำ Packing List และเอกสาร Out

เมนูหลัก:

- `Packing > Packing List Greige Out`
- `Packing > Packing List Dyed Out`
- `Packing > Packing List Cutting Out`

ตัวอย่างหน้าจอ `Packing List Dyed & Out`:

1. กด `New`
2. เลือกข้อมูลอ้างอิง เช่น `Request No.`, `DIN No.` หรือ `Lot No.`
3. ค้นหาเอกสารด้วยปุ่มค้นหา
4. ย้ายรายการเข้าหรือออกจาก Packing List ด้วยปุ่ม `...>` หรือ `<...`
5. ตรวจสอบข้อมูล
   - `Pack No.`
   - `Date`
   - `Customer`
   - `Carton No.`
   - `Rolls`, `Kgs`, `Yds`, `CBM`
6. เลือก `Auto Gen Carton No.` หากต้องการให้ระบบสร้างเลข Carton อัตโนมัติ
7. กด `Save`
8. พิมพ์เอกสารจาก `Print`
   - `PL Document`
   - `OUT Document`
   - `Tag`
9. หากต้องการพิมพ์ Label ให้ใช้ปุ่ม `Print Carton Label` หรือ `Print Carton Chantasia Label`

ข้อควรระวัง:

- ตรวจสอบจำนวน Roll/Kgs/Yds ก่อนบันทึก
- หน้าจอ Packing มีข้อความเตือนว่าไม่แสดง S/O Closed และ RD Cancel

## 16. การใช้งาน Purchase

เมนู `Purchase > Print P/O Control` ใช้พิมพ์หรือตรวจสอบรายงานควบคุม P/O

แนวทางการใช้งาน:

1. เปิดเมนู `Purchase > Print P/O Control`
2. ระบุเงื่อนไขที่ต้องการ
3. กด `Print`
4. ตรวจสอบรายงานก่อนนำไปใช้งาน

## 17. การใช้งาน Production

เมนู Production ใช้ติดตามแผนงานและรายงานการผลิต

เมนูหลัก:

- `Production > K/O Schedule Plan`
- `Production > Machine Capacity`
- `Production > Reports`

รายงานที่ใช้บ่อย:

- `Yarn Demand`
- `S/O Not Have K/O`
- `Machine Productivity`
- `Greige Monthly Production`
- `K/O Closed Report`
- `K/O Design History`
- `K/I Loss By Machine`
- `Design No. BOM`
- `K/O Outsource`
- `Yarn Test Form`

## 18. การใช้งาน Gamma Data

เมนู Gamma Data ใช้ตรวจสอบข้อมูลที่เกี่ยวข้องกับ Gamma และ Lab/Process Tracking

เมนูหลัก:

- `Gamma Data > Reports`
- `Gamma Data > Gamma CMR`
- `Gamma Data > Gamma Colour Matching Request Tracking`
- `Gamma Data > Production Processing Tracking Chart`
- `Gamma Data > Sample Stock Balance (Lab Dip)`
- `Gamma Data > Gamma Lab Stock Issue`
- `Gamma Data > Gamma Process Tracking`
- `Gamma Data > CMR Lab Status`

## 19. การใช้งาน Management

เมนู `Management > Management Summary Report` ใช้เรียกรายงานสรุปสำหรับผู้บริหารหรือหัวหน้างาน

แนวทางการใช้งาน:

1. เปิดเมนู `Management > Management Summary Report`
2. ระบุช่วงวันที่หรือเงื่อนไข
3. กดพิมพ์หรือแสดงรายงาน
4. ตรวจสอบยอดรวมก่อนนำเสนอ

## 20. การจัดการหน้าต่าง

ระบบสามารถเปิดหลายหน้าจอพร้อมกันได้ ใช้เมนู `Windows` เพื่อจัดการหน้าต่าง

- `Arrange Windows`: จัดเรียงหน้าต่าง
- `Change Password`: เปลี่ยนรหัสผ่าน
- `Exit`: ออกจากระบบ

## 21. แนวทางตรวจสอบเมื่อพบปัญหา

| ปัญหา | แนวทางแก้ไข |
| --- | --- |
| Login ไม่ได้ | ตรวจสอบ User name, Password, Database และ Warehouse |
| ระบบแจ้งเชื่อมต่อ Server ไม่ได้ | แจ้งผู้ดูแลระบบเพื่อตรวจสอบ Server/Network |
| ไม่เห็นบางเมนู | ตรวจสอบสิทธิ์การใช้งานกับผู้ดูแลระบบ |
| กด Print แล้วรายงานขึ้นช้า | รอให้ระบบประมวลผล หรือปรับช่วงวันที่ให้แคบลง |
| แก้ไข Order ไม่ได้ | ตรวจสอบสถานะ Order อาจ Confirm หรือ Closed แล้ว |
| ยอดในรายงานไม่ตรง | ตรวจสอบช่วงวันที่, เงื่อนไขรายงาน และสถานะเอกสาร |
| พิมพ์ Tag/Document ไม่ออก | ตรวจสอบเครื่องพิมพ์, Report path และสิทธิ์เข้าถึงไฟล์รายงาน |

## 22. ข้อควรระวังในการใช้งาน

- ตรวจสอบ Database ก่อน Login โดยเฉพาะกรณีมีฐานข้อมูลทดสอบ
- ก่อนกด `Save`, `Confirm`, `Cancel` หรือ `Close` ควรตรวจสอบข้อมูลให้ครบ
- ไม่ควรเปิดเอกสารเดียวกันแก้ไขพร้อมกันหลายคน
- ไม่ควรเปลี่ยนข้อมูล Master โดยไม่ตรวจสอบผลกระทบ
- ไม่ควรเปิดเผยรหัสผ่านให้ผู้อื่น
- หากไม่แน่ใจสถานะเอกสาร ให้ใช้รายงานหรือหน้าค้นหาตรวจสอบก่อนทำรายการต่อ

## 23. คำศัพท์ที่พบบ่อย

| คำศัพท์ | ความหมาย |
| --- | --- |
| `S/O` | Sales Order หรือใบสั่งขาย |
| `P/O` | Purchase Order หรือใบสั่งซื้อจากลูกค้า/ผู้ขาย |
| `D/F` | Dying/Dyeing Order งานย้อม |
| `DIN` | Dyed In เอกสารรับเข้าผ้าย้อม |
| `DOUT` | Dyed Out เอกสารจ่ายออกผ้าย้อม |
| `GIN` | Greige In เอกสารรับเข้าผ้าดิบ |
| `GOUT` | Greige Out เอกสารจ่ายออกผ้าดิบ |
| `K/O` | Knitting Order |
| `CMR` | Colour Matching Request |
| `Pending` | รายการค้างดำเนินการ |
| `Confirm` | ยืนยันเอกสารหรือ Order |
| `Close` | ปิดงานหรือปิด Order |

## 24. สรุป

การใช้งานระบบ Sales Order System ควรเริ่มจากตรวจสอบฐานข้อมูลและคลังสินค้าให้ถูกต้องก่อน Login จากนั้นเลือกเมนูตามงานที่ต้องทำ เช่น สร้าง Sales Order, พิมพ์เอกสาร, ตรวจสอบ Invoice, จัดการ Stock หรือเรียกรายงาน ผู้ใช้งานควรตรวจสอบข้อมูลสำคัญก่อนบันทึกและก่อนยืนยันเอกสารทุกครั้ง เพื่อให้ข้อมูลในระบบและรายงานถูกต้องตรงกัน
