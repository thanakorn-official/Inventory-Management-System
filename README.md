<p align="center">
  <img src="https://capsule-render.vercel.app/api?type=rect&color=11111b&height=150&section=header&text=📦%20INVENTORY%20MANAGEMENT%20SYSTEM&fontSize=35&animation=twinkling&fontColor=89b4fa&width=100%" alt="Project Header" width="100%" />
</p>

<p align="center">
  <img src="https://img.shields.io/badge/Architecture-Full_Stack-blue?style=for-the-badge" />
  <img src="https://img.shields.io/badge/Database-SQL-CC2927?style=for-the-badge&logo=microsoftsqlserver&logoColor=white" />
  <img src="https://img.shields.io/badge/Backend-Node.js-339933?style=for-the-badge&logo=nodedotjs&logoColor=white" />
  <img src="https://img.shields.io/badge/UI-Responsive_Web-orange?style=for-the-badge" />
</p>

---

### 📝 รายละเอียดโปรเจกต์ (Project Overview)
**Inventory-Management-System** เป็นเว็บแอปพลิเคชันแบบ Full-Stack ที่พัฒนาขึ้นเพื่อแก้ไขปัญหาและเพิ่มประสิทธิภาพในการบริหารจัดการคลังสินค้าแบบเรียลไทม์ ระบบนี้ช่วยให้ผู้ดูแลระบบสามารถบันทึก ตรวจสอบ ปรับปรุง และติดตามสถานะของสินค้าเข้า-ออก (Stock In / Stock Out) ได้อย่างแม่นยำ พร้อมทั้งมีระบบแจ้งเตือนเมื่อสินค้าใกล้หมดสต็อก (Low Stock Alert) เพื่อช่วยลดความผิดพลาดและเพิ่มความรวดเร็วในการทำงาน ⚡

---

### ✨ ฟีเจอร์เด่น (Key Features)
* 📥 **Stock In / Out Tracking:** ระบบบันทึกการรับสินค้าเข้าและการจ่ายสินค้าออกอย่างละเอียด พร้อมเก็บประวัติ (Transaction Logs)
* 📊 **Real-time Stock Level:** อัปเดตจำนวนสินค้าคงเหลือในคลังแบบอัตโนมัติทันทีที่มีการขยับเขยื้อนข้อมูล
* ⚠️ **Low Stock Alert:** ระบบตรวจสอบและแจ้งเตือนสถานะสินค้าแบบวิกฤตเมื่อจำนวนลดลงต่ำกว่าเกณฑ์ที่กำหนด
* 🔍 **Smart Search & Filter:** ค้นหาสินค้าและคัดกรองตามหมวดหมู่ (Category) หรือตำแหน่งการจัดเก็บได้อย่างรวดเร็ว
* 📋 **Dashboard Analytics:** หน้าสรุปข้อมูลภาพรวม มูลค่าคลังสินค้า และสินค้ายอดนิยมในรูปแบบที่เข้าใจง่าย

---

### 🛠️ เทคโนโลยีที่ใช้ (Tech Stack)
* **Frontend:** HTML5, CSS3, JavaScript (Responsive Design รองรับทุกหน้าจอ)
* **Backend Runtime:** Node.js 🟢
* **Database Management:** SQL / Relational Database (ออกแบบความสัมพันธ์ของข้อมูลอย่างถูกต้อง)
* **Version Control:** Git & GitHub 🛠️

---

### 🗂️ โครงสร้างฐานข้อมูลเบื้องต้น (Database Schema Preview)
> ออกแบบฐานข้อมูลตามหลัก Relational Database เพื่อรักษาความถูกต้องของข้อมูล (Data Integrity)

```sql
-- ตารางหมวดหมู่สินค้า
CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY IDENTITY(1,1),
    CategoryName VARCHAR(100) NOT NULL
);

-- ตารางข้อมูลสินค้า
CREATE TABLE Products (
    ProductID INT PRIMARY KEY IDENTITY(1,1),
    ProductName VARCHAR(150) NOT NULL,
    CategoryID INT FOREIGN KEY REFERENCES Categories(CategoryID),
    Price DECIMAL(10,2) NOT NULL,
    StockQuantity INT NOT NULL DEFAULT 0,
    MinStockLevel INT NOT NULL DEFAULT 5, -- เกณฑ์สำหรับแจ้งเตือนสินค้าใกล้หมด
    UpdatedAt DATETIME DEFAULT GETDATE()
);
