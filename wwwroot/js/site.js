let searchBox = document.querySelector('#searchBox');
let movieDetails = document.querySelector('.movieDetails');
let movieDetailsPanelDown = false;

if(searchBox != null)
  searchBox.focus();

  if(movieDetails != null){
    if(!movieDetailsPanelDown) {
      $('.movieDetails').animate(
        {
          top: 200
        }, 500, 'swing')
        movieDetailsPanelDown = true;
    }
    else {
      movieDetailsPanelDown = false;
    }
  }

  function ClosePanel(){
    $('.movieDetails').animate(
      {
        top:-2400
      }, 400, 'swing' )
      movieDetailsPanelDown = false;
  }