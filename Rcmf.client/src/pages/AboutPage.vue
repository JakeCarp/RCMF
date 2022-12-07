<template>


    <div class="hero-image text-center d-flex align-items-center justify-content-center">
      <h1 class="text-center text-light display-1 text-shadow">About us</h1>
    </div>

<div class="col-md-12 my-5">
  <!-- NavButtons -->
  <nav>
    <div class="nav nav-tabs rounded justify-content-center justify-content-evenly" id="nav-tab" role="tablist">
      <button v-motion-pop class="nav-link active" id="nav-home-tab" data-bs-toggle="tab" data-bs-target="#nav-home"
        type="button" role="tab" aria-controls="nav-home" aria-selected="true">
        <i class="mdi mdi-view-dashboard me-1"></i> DashBoard
      </button>
      <button v-motion-pop class="nav-link" id="nav-profile-tab" data-bs-toggle="tab" data-bs-target="#nav-profile"
        type="button" role="tab" aria-controls="nav-profile" aria-selected="false">
       Dogs
      </button>
      <button v-motion-pop class="nav-link" id="nav-contact-tab" data-bs-toggle="tab" data-bs-target="#nav-contact"
        type="button" role="tab" aria-controls="nav-contact" aria-selected="false">
        Cats
      </button>

      <button v-motion-pop class="nav-link" id="nav-fourth-tab" data-bs-toggle="tab" data-bs-target="#nav-fourth"
        type="button" role="tab" aria-controls="nav-fourth" aria-selected="false">
        Lizards
      </button>
    </div>
  </nav>
  <!-- !NavButtons -->
  <div class="tab-content" id="nav-tabContent">
    <div class="tab-pane fade show active" id="nav-home" role="tabpanel" aria-labelledby="nav-home-tab" tabindex="0">
      <!-- Tab1 -->
   <div class="container">
     <div class="row">
       <div class="col-md-12 my-3 ">
         Lorem ipsum dolor sit amet, consectetur adipisicing elit. Quod aliquid praesentium quaerat totam odit ea delectus est debitis obcaecati! Ex tempore doloribus laboriosam illum similique, earum nostrum cum labore rerum nam aliquid tempora dolor maxime sequi excepturi pariatur vel nobis rem ea magni quod repellendus dolorem perferendis. Delectus hic tempore eveniet beatae ratione porro voluptates dolorum rerum rem vitae incidunt natus est distinctio minima, adipisci suscipit deleniti architecto nostrum assumenda quae omnis atque animi dicta cumque. Voluptas voluptatum, sequi incidunt, enim perspiciatis ut labore accusantium dolore inventore, suscipit facilis dolor alias. Reiciendis eos possimus architecto eaque facilis quaerat ratione vitae error. Optio ab commodi, odit doloribus error sint et totam debitis veritatis perferendis. Deleniti, tempora assumenda. Itaque natus ullam consectetur optio! Voluptates corporis fugit incidunt ipsum, aperiam cumque nostrum ex facilis tempore dolores qui facere nesciunt aliquam mollitia porro deserunt repellat fugiat ut ea? Nisi at voluptates delectus corrupti eum ratione nesciunt eaque architecto tempore recusandae rerum consectetur tempora deleniti commodi vitae, alias suscipit aspernatur vel corporis! Eveniet delectus soluta libero nobis, error totam eligendi suscipit! Blanditiis velit perferendis nihil enim voluptatibus tenetur quibusdam architecto eos itaque alias. Sit voluptates consequuntur libero minus in odit, ea iusto eius nemo laborum.
       </div>
     </div>
   </div>
      <!-- !Tab1 -->
    </div>
    <div class="tab-pane fade" id="nav-profile" role="tabpanel" aria-labelledby="nav-profile-tab" tabindex="0">
      <!-- Tab2 -->
  
      <!-- !Tab2 -->
    </div>
    <div class="tab-pane fade" id="nav-contact" role="tabpanel" aria-labelledby="nav-contact-tab" tabindex="0">
      <!-- Tab3 -->
      <!-- !Tab3 -->
    </div>
    <div class="tab-pane fade" id="nav-fourth" role="tabpanel" aria-labelledby="nav-fourth-tab" tabindex="0">
      <!-- Tab4 -->
     
      <!-- !Tab4 -->
    </div>
  </div>
</div>
 
</template>

<script>
export default {
  setup() {
    return {

    }
  }
}
</script>
<style>
.navPanel {
  height: 90vh;
  width: auto;
}

.coosbay {
  height: 15rem;
  width: 15rem;
}

.navbg {
  background-color: #6a7b76fd;
}


.twofiremen {
  height: 16rem;
  width: 16.5rem;
}

.navButton {
  width: 15rem;
}

.hero-image {
  background-image: url(https://images.unsplash.com/photo-1575920197509-2de60ffa1b0e?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1848&q=80);
  height: 400px;
  width: 100vw;
  background-size: cover;
  background-position: center;
  background-attachment: fixed;
  border-radius: 4px;
}

.randyPic {
  height: 8rem;
}
</style>
