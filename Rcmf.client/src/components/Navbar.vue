<template>
  <nav class="navbar navbar-expand-lg navbar-dark bg-dark px-3">
    <router-link class="navbar-brand d-flex rounded-3 " :to="{ name: 'Home' }">
      <div class="d-flex flex-column align-items-center">
        <img alt="logo" src="http://ourfallenbrother.org/pictures/helmet.png" height="50" class="rounded-3 "/>
      </div>
    </router-link>
    <button
      class="navbar-toggler"
      type="button"
      data-bs-toggle="collapse"
      data-bs-target="#navbarText"
      aria-controls="navbarText"
      aria-expanded="false"
      aria-label="Toggle navigation"
    >
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarText">
      <ul class="navbar-nav mx-auto gap-5 ">
        <li>
          <router-link :to="{ name: 'Home' }" class="btn text-light   text-uppercase  ">
            Landing
          </router-link>
        </li>
        <li>
          <router-link :to="{ name: 'About' }" class="btn text-light   text-uppercase">
            About
          </router-link>
        </li>
        <li>
          <router-link :to="{ name: 'Sponsor' }" class="btn text-light   text-uppercase">
            Sponsor
          </router-link>
        </li>
        <li>
          <router-link :to="{ name: 'Tournament' }" class="btn text-light   text-uppercase">
            Tournament
          </router-link>
        </li>
        <li>
          <router-link :to="{ name: 'Donate' }" class="btn text-light   text-uppercase">
           Donate
          </router-link>
        </li>
        <li>
          <router-link :to="{ name: 'Admin' }" class="btn text-light   text-uppercase">
           Admin
          </router-link>
        </li>
      </ul>
      <!-- LOGIN COMPONENT HERE -->
      <!-- <Login /> -->
    </div>
  </nav>
</template>

<script>
import Login from './Login.vue'
export default {
  setup() {
    return {}
  },
  components: { Login }
}
</script>

<style scoped>
.btn{
  font-size: 1.5rem;
}
.btn:hover{
    border-bottom: 4px solid var(--bs-danger) !important;
    border: 0;
      border-bottom-left-radius: 0;
  border-bottom-right-radius: 0;
  color: var(--bs-danger) !important;
}
a:hover {
  text-decoration: none;
}

.nav-link {
  text-transform: uppercase;
}

.navbar-nav .router-link-exact-active {
  border-bottom: 4px solid var(--bs-danger);
  border-bottom-left-radius: 0;
  border-bottom-right-radius: 0;
    color: var(--bs-danger) !important;
    font-weight: 700;

}

.navbar-nav .router-link :hover{
    border-bottom: 4px solid var(--bs-danger);
}

@media screen and (min-width: 768px) {
  nav {
    height: 85px;
  }
}

</style>
