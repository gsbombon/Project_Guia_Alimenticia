@Code
    ViewData("Title") = "Home Page"
End Code

<!-- Hero Section Begin -->
<section class="hero-section set-bg" data-setbg="@Url.Content("~/Content/img/hero-bg.jpg")">
    <div class="container">
        <div class="row">
            <div class="col-lg-8">
                <div class="hero-text">
                    <span>ENTRENAMIENTOS | DIETAS</span>
                    <h1>GUIA ENTRENAMIENTO</h1>
                    <p>Registrate con nosotros y enmpieza a entrenar desde hoy<br /> Resultados asegurados en menos de un mes</p>
                    <a href="#" class="primary-btn">Leer Mas</a>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Hero Section End -->
<!-- About Section Begin -->
<section class="about-section spad">
    <div class="container">
        <div class="row">
            <div class="col-lg-6">
                <div class="about-pic">
                    <img src="@Url.Content("~/Content/img/about-pic.jpg")" alt="">
                    <a href="https://www.youtube.com/watch?v=SlPhMPnQ58k" class="play-btn video-popup">
                        <img src="@Url.Content("~/Content/img/play.png")" alt="">
                    </a>
                </div>
            </div>
            <div class="col-lg-6">
                <div class="about-text">
                    <h2>Beneficios</h2>
                    <p class="first-para">
                        Obtén acceso ilimitado a un amplio catálogo de rutinas y
                        programas de diferentes disciplinas para que entrenes cómo,
                        dónde y cuando quieras... gratis y para siempre.
                    </p>
                    <hr />
                    <h3>Lleva tu entrenamiento contigo</h3>
                    <p></p>
                    <p class="second-para">
                        Ve tus clases donde sea con acceso móvil vía iOS y Android,
                        o web y próximamente desde tu TV.
                    </p>
                    <a href="#" class="primary-btn">Read More</a>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- About Section End -->
<!-- Services Section Begin -->
<section class="services-section">
    <div class="container-fluid">
        <div class="row">
            <div class="col-lg-6">
                <div class="services-pic">
                    <img src="@Url.Content("~/Content/img/services/service-pic.jpg")" alt="">
                </div>
            </div>
            <div class="col-lg-6">
                <div class="service-items">
                    <div class="row">
                        <div class="col-md-6">
                            <div class="services-item bg-gray">
                                <img src="@Url.Content("~/Content/img/services/service-icon-1.png")" alt="">
                                <h4>POWER</h4>
                                <p>
                                    Aenean massa. Cum sociis Theme et natoque penatibus et magnis dis part urient
                                    montes.
                                </p>
                            </div>
                            <div class="services-item bg-gray pd-b">
                                <img src="@Url.Content("~/Content/img/services/service-icon-3.png")" alt="">
                                <h4>KICKBOX</h4>
                                <p>
                                    Aenean massa. Cum sociis Theme et natoque penatibus et magnis dis part urient
                                    montes.
                                </p>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="services-item">
                                <img src="@Url.Content("~/Content/img/services/service-icon-2.png")" alt="">
                                <h4>YOGA</h4>
                                <p>
                                    Aenean massa. Cum sociis Theme et natoque penatibus et magnis dis part urient
                                    montes.
                                </p>
                            </div>
                            <div class="services-item pd-b">
                                <img src="@Url.Content("~/Content/img/services/service-icon-4.png")" alt="">
                                <h4>CARDIO</h4>
                                <p>
                                    Aenean massa. Cum sociis Theme et natoque penatibus et magnis dis part urient
                                    montes.
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Services Section End -->
<!-- Trainer Section Begin -->
<section class="trainer-section spad">
    <div class="container">
        <div class="row">
            <div class="col-lg-12">
                <div class="section-title">
                    <h2>Entrenadores Expertos</h2>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-4 col-md-6">
                <div class="single-trainer-item">
                    <img src="@Url.Content("~/Content/img/trainer/trainer-1.jpg")" alt="">
                    <div class="trainer-text">
                        <h5>Sawyer Bruns</h5>
                        <span>Power Coach</span>
                        <p>
                            non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat
                            voluptatem.
                        </p>
                        <div class="trainer-social">
                            <a href="#"><i class="fa fa-facebook"></i></a>
                            <a href="#"><i class="fa fa-instagram"></i></a>
                            <a href="#"><i class="fa fa-twitter"></i></a>
                            <a href="#"><i class="fa fa-pinterest"></i></a>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-lg-4 col-md-6">
                <div class="single-trainer-item">
                    <img src="@Url.Content("~/Content/img/trainer/trainer-2.jpg")" alt="">
                    <div class="trainer-text">
                        <h5>Oren Willis</h5>
                        <span>Gym Coach</span>
                        <p>
                            non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat
                            voluptatem.
                        </p>
                        <div class="trainer-social">
                            <a href="#"><i class="fa fa-facebook"></i></a>
                            <a href="#"><i class="fa fa-instagram"></i></a>
                            <a href="#"><i class="fa fa-twitter"></i></a>
                            <a href="#"><i class="fa fa-pinterest"></i></a>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-lg-4 col-md-6">
                <div class="single-trainer-item">
                    <img src="@Url.Content("~/Content/img/trainer/trainer-3.jpg")" alt="">
                    <div class="trainer-text">
                        <h5>Taysha Atkinson</h5>
                        <span>Cardio Trainer</span>
                        <p>
                            non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat
                            voluptatem.
                        </p>
                        <div class="trainer-social">
                            <a href="#"><i class="fa fa-facebook"></i></a>
                            <a href="#"><i class="fa fa-instagram"></i></a>
                            <a href="#"><i class="fa fa-twitter"></i></a>
                            <a href="#"><i class="fa fa-pinterest"></i></a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Trainer Section End -->
