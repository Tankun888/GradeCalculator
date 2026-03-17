นาย เเทนคุณ ทันเขิม
รหัสนศ683450064-0

# ระบบคำนวณเกรด (TankunGrade)

โปรแกรมนี้เป็นโปรแกรมคำนวณเกรดของรายวิชา  
เขียนด้วยภาษา C# โดยใช้แนวคิด OOP (Object-Oriented Programming)

---

## ความสามารถของโปรแกรม
- สามารถเปิดวิชาใหม่ได้ (ใส่ชื่อวิชา รหัสวิชา และอาจารย์ผู้สอน)
- สามารถเพิ่มข้อมูลนักศึกษาได้ (ชื่อ รหัส และคะแนน)
- โปรแกรมจะคำนวณเกรดให้อัตโนมัติ
- แสดงรายชื่อนักศึกษาทั้งหมด
- แสดงคะแนนสูงสุด และต่ำสุด
- แสดงค่าเฉลี่ยของคะแนน
- เรียงคะแนนจากมากไปน้อย
- สามารถพิมพ์ exit เพื่อออกจากโปรแกรมได้

---

## เกณฑ์การให้เกรด
- A : 80 - 100
- B+ : 75 - 79
- B : 70 - 74
- C+ : 65 - 69
- C : 60 - 64
- D+ : 55 - 59
- D : 50 - 54
- F : 0 - 49

---

## โครงสร้างคลาส (Class Diagram)

```mermaid
classDiagram

class Person {
    <<abstract>>
    - name : string
    + show()*
}

class Student {
    - id : string
    - score : double
    + getScore()
    + getGrade()
    + show()
}

class Teacher {
    + show()
}

class Course {
    - cname : string
    - cid : string
    - students : List~Student~
    + addStudent()
    + showAll()
    + sortScore()
    + showMaxMin()
    + showAvg()
}

Person <|-- Student
Person <|-- Teacher
Course "1" --> "*" Student
Course "1" --> "1" Teacher
