



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cauhoi : MonoBehaviour
{
    ColorBlock cb = new ColorBlock();
    ColorBlock cba = new ColorBlock();
    ColorBlock cbr = new ColorBlock();
    public FixedJoystick joystick;
    public GameObject co1;
    public GameObject co2;
    public GameObject co3;
    public GameObject co4;
    public GameObject co5;
    public GameObject co6;
    public GameObject co7;
    public GameObject co8;
    public GameObject co9;
    public GameObject co10;
    public GameObject co11;
    public GameObject co12;
    public GameObject co13;
    
    public float dist1;
    public float dist2;
    public float dist3;
    public float dist4;
    public float dist5;
    public float dist6;
    public float dist7;
    public float dist8;
    public float dist9;
    public float dist10;
    public float dist11;
    public float dist12;
    public float dist13;
    public Text dunghaychua;
    public Vector3 og;
    public int collected = 13;
    public Text myText;
    public Text cauhoitext;
    public Text a;
    public Text b;
    public Text c;
    public Button A;
    public Button B;
    public Button C;
    public List<WheelCollider> throttleWheels;
    public string currtraloi;
    public int index;
    List<string> ch = new List<string>(new string[] {"Trong đô thị và khu đông dân cư từ 22 giờ đến 5 giờ, xe xin vượt phải báo thế nào?","Khi đèn tín hiệu giao thông màu vàng bật sáng, người điều khiển phương tiện giao thông chưa đến vạch dừng phải làm gì?","Đèn giao thông dành cho người đi bộ có mấy màu?","Người điều khiển xe môtô dưới 50 phân khối bắt buộc phải có giấy tờ gì?","Người điều khiển xe môtô 2 bánh, 3 bánh có dung tích xi lanh từ 50 cm3 trở lên phải đủ bao nhiêu tuổi?","Tại nơi đường giao nhau có báo hiệu đi theo vòng xuyến, người điều khiển phương tiện phải nhường đường như thế nào?","Xe đạp được kéo đẩy nhau hoặc vật gì khác trên đường hay không?","Người ngồi trên xe môtô 2 bánh, 3 bánh khi tham gia giao thông có được mang vác vật cồng kềnh hay không?","Biển báo sau được dùng để làm gì?","Biển báo sau có ý nghĩa gì?","Khi gặp một đoàn xe, đoàn xe tang hay một đoàn người có tổ chức đi theo hàng ngũ, người lái xe phải xử lý thế nào cho đúng quy tắc giao thông?"});
    List<string> cha = new List<string>(new string[] {"Báo bằng đèn tín hiệu.","Tiếp tục đi nhưng phải chú ý quan sát tránh gây tai nạn giao thông.","1 màu","Chứng nhận đăng kí xe","16 tuổi","Phải nhường đường cho xe đi bên phải","Được phép","Được mang vác tùy trường hợp cụ thể","Cấm tất cả các xe, kể cả các xe được ưu tiên theo quy định","Tải trọng tối đa của xe cho phép lưu thông","Bóp còi, rú ga để cắt ngang qua"});
    List<string> chb = new List<string>(new string[] {"Báo bằng còi(kèn).","Dừng lại trước vạch dừng.","2 màu","Bảo hiểm dân sự","18 tuổi","Xe báo hiệu xin đường trước được đi trước","Tùy trường hợp","Không được mang vác","Cấm mọi loại xe(cơ giới và thô sơ) đi theo chiều đặt biển, trừ các xe được ưu tiên theo quy định","Tốc độ tối đa cho phép các xe lưu thông","Báo hiệu và từ từ cho xe đi qua để đảm bảo an toàn"});
    List<string> chc = new List<string>(new string[] {"Cả hai ý trên.","Được đi tiếp nhưng chỉ được rẽ trái","3 màu","Cả hai ý trên","20 tuổi","Phải nhường đường cho xe đi bên trái","Tuyệt đối không","Được mang, vác nhưng phải đảm bảo an toàn","Cấm tất cả các loại xe(cơ giới và thô sơ) đi lại hai hướng, trừ các xe được ưu tiên theo quy định","Tốc độ tối thiểu bắt buộc các xe lưu thông","Chờ đoàn xe, người đi qua hết thì mới tiếp tục lưu thông"});
    List<string> traloi = new List<string>(new string[] {"a","b","b","c","b","c","c","b","c","b","c"});

    List<string> image = new List<string>(new string[] {"Images/y","Images/denvang","Images/y","Images/y","Images/y","Images/vongxuyen","Images/y","Images/congkenh","Images/duongcam","Images/tocdo","Images/y"});
    public GameObject dia;
    public GameObject dia2;
    public GameObject accomp;
    public GameObject cont;
    public Image img;
    
    // Start is called before the first frame update
    void Start()
    {
    
        dia.SetActive(false);
        dia2.SetActive(false);
        accomp.SetActive(false);
        cont.SetActive(true);
        a.fontStyle=FontStyle.Normal;
        b.fontStyle=FontStyle.Normal;
        c.fontStyle=FontStyle.Normal;
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.SetActive(true);
        og = transform.position;
        dist1 = Vector3.Distance(og,co1.transform.position);
        dist2 = Vector3.Distance(og,co2.transform.position);
        dist3 = Vector3.Distance(og,co3.transform.position);
        dist4 = Vector3.Distance(og,co4.transform.position);
        dist5 = Vector3.Distance(og,co5.transform.position);
        dist6 = Vector3.Distance(og,co6.transform.position);
        dist7 = Vector3.Distance(og,co7.transform.position);
        dist8 = Vector3.Distance(og,co8.transform.position);
        dist9 = Vector3.Distance(og,co9.transform.position);
        dist10 = Vector3.Distance(og,co10.transform.position);
        dist11 = Vector3.Distance(og,co11.transform.position);
        dist12 = Vector3.Distance(og,co12.transform.position);
        dist13 = Vector3.Distance(og,co13.transform.position);
        
        if (dist1 < 7f){
            hoi();
            
        } else if (dist2 < 7f) {
            hoi();
            
        } else if (dist3 < 7f) {
            hoi();
            
        } else if (dist4 < 7f) {
            hoi();
            
        } else if (dist5 < 7f) {
            hoi();
            
        } else if (dist6 < 7f) {
            hoi();
            
        } else if (dist7 < 7f) {
            hoi();
            
        } else if (dist8 < 7f) {
            hoi();
            
        } else if (dist9 < 7f) {
            hoi();
            
        } else if (dist10 < 7f) {
            hoi();
            
        } else if (dist11 < 7f) {
            hoi();
            
        } else if (dist12 < 7f) {
            hoi();
            
        } else if (dist13 < 7f){
            hoi();
            
        } else{
            no();
            
        }
        
        myText.text = collected.ToString() + " / 13";
        if (collected > 7){
            win();
        }
    }
    public void hoi(){
        dia2.SetActive(true);
    }
    public void hoiok(){
        dia2.SetActive(false);
        if (dist1 < 7f){
            
            co1.SetActive(false);
            co1.transform.position += new Vector3(1000,100,1000);
        } else if (dist2 < 7f) {
            
            co2.SetActive(false);
            co2.transform.position += new Vector3(1000,100,1000);
        } else if (dist3 < 7f) {
            
            co3.SetActive(false);
            co3.transform.position += new Vector3(1000,100,1000);
        } else if (dist4 < 7f) {
            
            co4.SetActive(false);
            co4.transform.position += new Vector3(1000,100,1000);
        } else if (dist5 < 7f) {
           
            co5.SetActive(false);
            co5.transform.position += new Vector3(1000,100,1000);
        } else if (dist6 < 7f) {
            
            co6.SetActive(false);
            co6.transform.position += new Vector3(1000,100,1000);
        } else if (dist7 < 7f) {
            
            co7.SetActive(false);
            co7.transform.position += new Vector3(1000,100,1000);
        } else if (dist8 < 7f) {
            
            co8.SetActive(false);
            co8.transform.position += new Vector3(1000,100,1000);
        } else if (dist9 < 7f) {
            
            co9.SetActive(false);
            co9.transform.position += new Vector3(1000,100,1000);
        } else if (dist10 < 7f) {
            
            co10.SetActive(false);
            co10.transform.position += new Vector3(1000,100,1000);
        } else if (dist11 < 7f) {
            
            co11.SetActive(false);
            co11.transform.position += new Vector3(1000,100,1000);
        } else if (dist12 < 7f) {
            
            co12.SetActive(false);
            co12.transform.position += new Vector3(1000,100,1000);
        } else if (dist13 < 7f){
            
            co13.SetActive(false);
            co13.transform.position += new Vector3(1000,100,1000);
        }
        hoir();

    }
    public void no(){
        dia2.SetActive(false);
    }
    void hoir(){
        /*cb.normalColor = Color.green;
        cba.normalColor = Color.white;
        cbr.normalColor = Color.red;
        A.colors=cba;
        B.colors=cba;
        C.colors=cba;*/
        dia.SetActive(true);
        joystick.DeadZone=100f;
        index = Random.Range(0,ch.Count);
        
        cauhoitext.text = ch[index];
        a.text = cha[index];
        b.text = chb[index];
        c.text = chc[index];
        currtraloi = traloi[index];
        ch.RemoveAt(index);
        cha.RemoveAt(index);
        chb.RemoveAt(index);
        chc.RemoveAt(index);
        traloi.RemoveAt(index);
        dunghaychua.text="";
        a.fontStyle=FontStyle.Normal;
        b.fontStyle=FontStyle.Normal;
        c.fontStyle=FontStyle.Normal;
        img.sprite = Resources.Load<Sprite>(image[index]);
        image.RemoveAt(index);
        
    }
    
    public void caua(){
        if (currtraloi == "a"){
            collected += 1;
            
            /*B.colors= cba;
            C.colors= cba;*/
            
            b.text = "";
            c.text = "";
            dunghaychua.text="Đúng rồi!";
            a.fontStyle=FontStyle.Bold;
            /*A.colors =  cb;*/
        } else {
            
            dunghaychua.text = "Chưa đúng, đáp án đúng là: " + currtraloi;
            A.colors=cbr;
            if (currtraloi!="b") {
                
                c.fontStyle=FontStyle.Bold;
                /*C.colors= cb;
                B.colors= cba;*/
            } else {
                /*B.colors= cb;
                C.colors= cba;*/
                b.fontStyle=FontStyle.Bold;
            }
        }
        currtraloi = "";
        
        Invoke("hidthedia",5.0f);
    }
    public void caub(){
        if (currtraloi == "b"){
            collected += 1;
            
            a.text = "";
            
            c.text = "";
            dunghaychua.text="Đúng rồi!";
            b.fontStyle=FontStyle.Bold;
        } else {
            
            dunghaychua.text = "Chưa đúng, đáp án đúng là " + currtraloi;
            
            if (currtraloi!="a") {
                
                c.fontStyle=FontStyle.Bold;
            } else {
                
                a.fontStyle=FontStyle.Bold;
            }
            
        }
        currtraloi = "";
        Invoke("hidthedia",5.0f);
    }
    public void cauc(){
        if (currtraloi == "c"){
            collected += 1;
            
            a.text = "";
            b.text = "";
            dunghaychua.text="Đúng rồi!";
            c.fontStyle=FontStyle.Bold;
        } else {
            
            dunghaychua.text = "Chưa đúng, đáp án đúng là: " + currtraloi;
            
            if (currtraloi!="b") {
                
                a.fontStyle=FontStyle.Bold;
            } else {
                
                b.fontStyle=FontStyle.Bold;
            }
        }
        currtraloi = "";
        Invoke("hidthedia",5.0f);
    }

    public void hidthedia(){
        dia.SetActive(false);
        joystick.DeadZone = 0f;
        foreach (WheelCollider wheel in throttleWheels)
        {
            wheel.brakeTorque = 0f;
            
        }
    }
    public void win(){
        cont.SetActive(false);
        dia.SetActive(false);
        accomp.SetActive(true);
        gameObject.SetActive(false);
    }
}