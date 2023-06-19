<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Locationdetail.aspx.cs" Inherits="Tourist_website_rajastan.Locationdetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--style tag is added here-->
    <style>

      .location-body{
    background-color: #191919;
    color: white;
}

.location-section{
    padding: 110px;
    height: 100%;
    min-height: 100vh;
}

.location-heading h1{
    margin-top: 20px;
    font-size: 60px;
    margin-bottom: 20px;
    opacity: 0.9;

}

.location-heading h1 span{
    color: #fc0050;
}

.location-detail h1{
    padding-top: 155px;
    color: #fc0050;
    font-size: 40px;
}

.location-detail p{
        color: white;
    font-size: 20px;
    margin-top: 40px;
    margin-bottom: 10px;
}

.location-img img{
    height: 400px;
    width: 400px;
    margin-top: 30px;
    margin-bottom: 30px;
}

.stars i{
    font-size: 20px;
    color: rgb(197, 167, 44);
}
/*banner css code start here*/

.banner{
    width:100%;
    height: 100vh;
    overflow: hidden;
    display: flex;
    justify-content: center;
    align-items: center;
}

.banner video{
    position: absolute;
    top: 0;
    left: 0;
    object-fit: cover;
    width: 100%;
    height: 100%;
    pointer-events: none;
}

        </style>
    <!-- Background Video & Header -->

    <div class="banner" style="height=50">
        <video src="./assets/images/Rajsathan_vid.mp4" type="video/mp4" autoplay muted loop  style="height:111%;width:100%;margin-top: 7em;opacity:1;"></video>
        </div>

    <!--Code is added from here-->
    
     <section class="location-section">
    <div class="location-heading">
        <h1>Discover The <span>Beautiful World</span></h1>
    </div>
 <div class="location-detail" id="kashmir">
    <h1>Jaipur</h1>
    <div class="stars">
        <a href="#"><i class='bx bxs-star'></i></a>
        <a href="#"><i class='bx bxs-star'></i></a>
        <a href="#"><i class='bx bxs-star'></i></a>
        <a href="#"><i class='bx bxs-star'></i></a>
        <a href="#"><i class='bx bxs-star'></i></a>
    </div>
    <p>Jaipur is a place not less than a paradise. It is impossibly romantic and picturesque, decked with royal palaces atmospheric Havlies, eclectic museums, and ancient towering temples. It is more than just a city. It is not wrong to say that Jaipur as a city is the soul of Indian culture. Fusion of old and modern, Chaotic yet tranquil welcoming and hospitable Jaipur is the beating heart of Rajasthan Tourism.
        he pink city of Jaipur is a UNESCO world heritage site. At the city’s heart, the city palace is still a home to the last ruling family. It paints a beautiful picture of Mughal and Rajput architecture.

        Some of the popular heritage points of tourist interest in Jaipur are Hawa Mahal, Amber Fort, Sunehri kothi, Jantar Mantar, Jai Mahal, Rambagh palace, Rajmahal Palace and many others. Each tourist places in Jaipur maintains a heavenly aspect.
    </p>
    <div class="location-img">
        <img src="./assets/images/I1.jpg" alt="">
    </div>
 </div>

 <div class="location-detail" id="istanbul">
    <h1>Jodhpur</h1>
    <div class="stars">
        <a href="#"><i class='bx bxs-star'></i></a>
        <a href="#"><i class='bx bxs-star'></i></a>
        <a href="#"><i class='bx bxs-star'></i></a>
        <a href="#"><i class='bx bxs-star'></i></a>
        <a href="#"><i class='bx bxs-star-half'></i></a>
    </div>
    <p>Jodhpur is a sunny city set against a bright blue sky. A popular travel destination in Rajasthan Jodhpur was formerly the capital of the Marwar kingdom. A city grew outside the limits of the fort in olden times. Modern Jodhpur has grown and expanded though its palaces, forts and temples are favoured tourist attractions featuring beautiful architecture cradled in the sandy folds of the Thar Desert. A proper holiday guide to Jodhpur will enable you to plan your next vacation where there is so much to experience and enjoy.</p>
    <div class="location-img">
        <img src="./assets/images/I2.jpg" alt="">
    </div>
 </div>

 <div class="location-detail" id="paris">
    <h1>Bikaner</h1>
    <div class="stars">
        <a href="#"><i class='bx bxs-star'></i></a>
        <a href="#"><i class='bx bxs-star'></i></a>
        <a href="#"><i class='bx bxs-star'></i></a>
        <a href="#"><i class='bx bxs-star'></i></a>
        <a href="#"><i class='bx bxs-star-half'></i></a>
    </div>
    <p>Bikaner is home to one of the only two models of the biplane used by the British during World War I. They were presented by the British to Maharaja Ganga Singh, then ruler of the city. Another unique aspect about Bikaner are the sand dunes that are scattered throughout the district, especially from the north-east down to the southern area. Bikaner is situated in the northern region of Rajasthan. One of the earlier established cities, Bikaner still displays its ancient opulence through palaces and forts, built of red sandstone, that have withstood the passage of time. The city boasts of some of the world’s best riding camels and is aptly nicknamed ‘camel country’. It is also home to one of the world’s largest camel research and breeding farms; as well as being known for having its own unique temple dedicated to Karni Mata at Deshnok, called the Rats Temple.

The origins of Bikaner can be traced back to 1488 when a Rathore prince, Rao Bikaji, founded the kingdom. Legend has it that Bikaji, one of Rao Jodhaji’s five sons, left his father’s Durbar in annoyance after an insensitive remark from his father, the illustrious founder of Jodhpur. Bikaji travelled far and when he came upon the wilderness called Jangladesh, he decided to set up his own kingdom and transformed it into an impressive city.</p>
    <div class="location-img">
        <img src="./assets/images/I3.jpg" alt="">
    </div>
 </div>

 <div class="location-detail" id="bali">
    <h1>Ramthobare National Park</h1>
    <div class="stars">
        <a href="#"><i class='bx bxs-star'></i></a>
        <a href="#"><i class='bx bxs-star'></i></a>
        <a href="#"><i class='bx bxs-star'></i></a>
        <a href="#"><i class='bx bxs-star'></i></a>
        <a href="#"><i class='bx bxs-star-half'></i></a>
    </div>
    <p>Ranthambore National Park is located about 13.5 kilometers from the city of Sawai Madhopur in Rajasthan. Located at the junction of the Aravali and Vindhya hill ranges, this is one of the finest places to view wild animals, especially as they are used to being stared at here. The park covers an area of approximately 400 sq km, and if combined with the area of Sawai Man Singh Sanctuary area, is around 500 sq km. 

Ranthambore National Park is dotted with structures that remind you of bygone eras. There are numerous water bodies scattered all across the park, which provide perfect relief to the wild animals during the scorching hot days in summers. A huge fort, after which the park is named, towers over the park atop a hill. There are many ruins of bygone eras scattered all over the jungle, which give it a unique, wonderful and mixed flavour of nature, history and wildlife. Tigers at Ranthambore National park have been known to even hunt in full view of human visitors.</p>
    <div class="location-img">
        <img src="./assets/images/I4.jpg" alt="">
    </div>
 </div>

 <div class="location-detail" id="dubai">
    <h1>Jaisalmer</h1>
    <div class="stars">
        <a href="#"><i class='bx bxs-star'></i></a>
        <a href="#"><i class='bx bxs-star'></i></a>
        <a href="#"><i class='bx bxs-star'></i></a>
        <a href="#"><i class='bx bxs-star'></i></a>
        <a href="#"><i class='bx bxs-star'></i></a>
    </div>
    <p>If geology interests you, then Jaisalmer is where you need to journey. The Wood Fossil Park or Aakal is located about 15 kilometres away from the city. Here, one can discover and trace geologic tragedies that occurred in the Thar Desert 180 million years ago. The city of Jaisalmer also acts as the guard to western Rajasthan (and India’s) frontier. This 'Golden City’ is located close to the Pakistan border and in close proximity to the Thar Desert. The city’s most prominent landmark is the Jaisalmer Fort, also called Sonar Qila (Golden Fort). Unlike most other forts in India, Jaisalmer Fort is not just a tourist attraction. It houses shops, hotels and ancient havelis (homes) where generations continue to live.

Jaisalmer traces its inception to the 12th century. History tells us of Rawal Jaisal, the eldest heir of the Rawal of Deoraj, was passed over for the throne of Lodurva and a younger half-brother was crowned king. Rawal Jaisal went looking for a new location to set up his capital when he came across sage Eesul. The sage told him about Krishna’s prophecy which said that a descendant of his Yaduvanshi clan would found a new kingdom at this same spot. It was in 1156 that Rawal Jaisal constructed a mud fort, named it Jaisalmer after himself and declared it his capital.</p>
    <div class="location-img">
        <img src="./assets/images/I5.jpg" alt="">
    </div>
 </div>

 <div class="location-detail" id="geneva">
    <h1>Pushkar</h1>
    <div class="stars">
        <a href="#"><i class='bx bxs-star'></i></a>
        <a href="#"><i class='bx bxs-star'></i></a>
        <a href="#"><i class='bx bxs-star'></i></a>
        <a href="#"><i class='bx bxs-star-half'></i></a>
    </div>
    <p>Pushkar is one of the oldest cities in India. Located to the northwest of Ajmer, the tranquil city of Pushkar is a favoured destination for thousands of tourists and devotees flocking to Rajasthan. Situated at a height of 510 metres, Pushkar is surrounded by hillocks on three sides. The ‘Nag Pahar’, literally meaning Snake Mountain forms a natural border between Ajmer and Pushkar. Known as ‘the rose garden of Rajasthan’, the essence of the famous Pushkar rose is exported all over the world. Along with an interesting mythological history, a legacy of timeless architectural heritage makes Pushkar a fascinating city.

       According to legends, Lord Brahma, believed to be the creator of the Universe dropped a lotus to the ground leading to the immediate creation of a lake. He then decided to name the place after the flower, and thus the name, Pushkar. The city of Pushkar is home to the only temple dedicated to Lord Brahma in the whole world. Hindus consider a journey to Pushkar to be the ultimate pilgrimage that must be undertaken to attain salvation.</p>
    <div class="location-img">
        <img src="./assets/images/I6.jpg" alt="">
    </div>
 </div>

 <div class="location-detail" id="port-blair">
    <h1>Udaipur</h1>
    <div class="stars">
        <a href="#"><i class='bx bxs-star'></i></a>
        <a href="#"><i class='bx bxs-star'></i></a>
        <a href="#"><i class='bx bxs-star'></i></a>
        <a href="#"><i class='bx bxs-star'></i></a>
        <a href="#"><i class='bx bxs-star-half'></i></a>
    </div>
    <p>Udaipur, no doubt will definitely rejuvenate your body and soul because multiple lakes adorn this city. For this particular reason, Udaipur is also known as ‘Venice of the East’. The lakes of Udaipur are a poetry of charm and enchantment which has been luring tourists for ages.

You would see tourists enjoy a lazy lake day on a boat ride and be lost in the mesmerizing beauty of nature. Some tourists would enjoy the romantic atmosphere of the lakes. Some lakes would give you the reflection of the rich history of the region. Explore best romantic places to stay in Udaipur.

Some lakes of Udaipur like Lake Pichola are even featured in Hollywood and Bollywood movies. Some lakes would take you to green fields and farms, narrow pathways, scenic villages. Some of the most popular lakes of Udaipur are Fateh Sagar Lake, Lake Pichola, Udaisagar Lake, Jaisamand Lake, Badi Lake, Doodh Talai etc. Visiting Udaipur would be one of the best things to do in Udaipur if you want to experience the feel of Venice in India.</p>
    <div class="location-img">
        <img src="./assets/images/I7.jpg" alt="">
    </div>
 </div>

 <div class="location-detail" id="rome">
    <h1>Chittorgarh</h1>
    <div class="stars">
        <a href="#"><i class='bx bxs-star'></i></a>
        <a href="#"><i class='bx bxs-star'></i></a>
        <a href="#"><i class='bx bxs-star'></i></a>
        <a href="#"><i class='bx bxs-star'></i></a>
    </div>
    <p>Chittorgarh, also spelled Chittaurgarh, is in the southern part of Rajasthan, lies on the Berach River, a tributary of the Banas, and is the administrative headquarters of Chittorgharh District. It is 112 km from Udaipur and 182 km from Ajmer. The city served as a capital to the Sisodia clans of Rajputs of Mewar for a long time. The district is a famous tourist destination for its massive fortress, claimed to be the largest of all Rajput forts, and has witnessed the legendary tale of Queen Padmini's act of jauhar that fascinates many historians and travellers.
        Chittorgarh remains replete with historic associations and holds a very special place in the hearts of Rajputs, as it was a bastion of the clan at a time when every other stronghold had succumbed to invasion. The fort and the city of Chittorgarh also host the biggest Rajput festival, "Jauhar Mela". It takes place annually on the anniversary of one of the Jauhars (though not the one by Padmini which is most famous). This festival is to commemorate the bravery of their Rajput ancestors and all three Jauhars which happened at Chittorgarh. A huge number of Rajputs, which include the descendants of most of the princely families, do a procession to celebrate the Jauhar.
    </p>
    <div class="location-img">
        <img src="./assets/images/I8.jpg" alt="">
    </div>
 </div>
    </section>

     <!--Code end here-->


</asp:Content>
