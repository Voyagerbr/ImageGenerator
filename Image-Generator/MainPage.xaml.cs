namespace Image_Generator;

public partial class MainPage : ContentPage
{
  string[] images = new string[11];
  Random random = new Random();
  string? fraseGerada = null;

	public MainPage()
	{
		InitializeComponent();
		images[0] = "https://s2-techtudo.glbimg.com/SSAPhiaAy_zLTOu3Tr3ZKu2H5vg=/0x0:1024x609/888x0/smart/filters:strip_icc()/i.s3.glbimg.com/v1/AUTH_08fbf48bc0524877943fe86e43087e7a/internal_photos/bs/2022/c/u/15eppqSmeTdHkoAKM0Uw/dall-e-2.jpg";
		images[1] = "https://s1.1zoom.me/big0/815/Sunrises_and_sunsets_Hands_Sun_571948_1280x918.jpg";
		images[2] = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ34iEOaXace3VrMFdmWGZlPt_tA45DhQgVUA&usqp=CAU";
		images[3] = "https://www.designerd.com.br/wp-content/uploads/2019/04/imagens-blogs-chamar-atencao-publico-1.jpg";
		images[4] = "https://s2-g1.glbimg.com/c1tS_axTjV_qDkmMeMs3wYZCgGY=/0x0:5472x3648/1008x0/smart/filters:strip_icc()/i.s3.glbimg.com/v1/AUTH_59edd422c0c84a879bd37670ae4f538a/internal_photos/bs/2017/H/v/pTatikTlSIWRuTzd0JwA/j9a6180.jpg";
		images[5] = "https://t.ctcdn.com.br/JlHwiRHyv0mTD7GfRkIlgO6eQX8=/640x360/smart/i257652.jpeg";
		images[6] = "https://media.istockphoto.com/id/1126841725/pt/foto/spring-meadow.webp?b=1&s=170667a&w=0&k=20&c=10jxn9__bCmUoosFwhk7WIf1qTNsHM3j8yynMJo7OH8=";
		images[7] = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ5SWkYdCq8-Od-1_tpQg2DhAo4YHG8idXQBQ&usqp=CAU";	
		images[8] = "https://static.vecteezy.com/ti/fotos-gratis/t1/23007719-roxa-espaco-papel-de-parede-do-terra-e-lua-ai-gerado-foto.jpg";
		images[9] = "https://anselmohoffmann.com.br/wp-content/uploads/2021/05/como-usar-a-cor-na-fotografia-de-paisagem-1.jpg";
		images[10] = "https://gooutside.com.br/wp-content/uploads/sites/3/2022/11/image-6-e1668801883861.jpg";

	}

  void GerarButtonIsClicked(System.Object sender, System.EventArgs e)
  {
	int indice = random.Next(0, 10);
	imageMsg.Source = images[indice];
	fraseGerada = images[indice];
  }
  
private async void ShareButtonIsClicked(object sender, EventArgs args)
  {
    if (fraseGerada != null)
    {
      await Share.Default.RequestAsync(new ShareTextRequest
      {
          Text = fraseGerada,
          Title = "Gerador de Imagens"
      });
    }
  }

}

