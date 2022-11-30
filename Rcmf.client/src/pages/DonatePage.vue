<template>
  <div class="container">
    <div class="row justify-content-center">
      <div class="col-md-12 text-center">
        <h1 class="display-3 abril"> Donation Page</h1>
      </div>
      <div class="col-md-12 heroImg elevation-6">

      </div>
    </div>
    
    <!-- <div class="row">
      <div class="col-md-12">DONATE PAGE</div>
      <div>
        <form @submit.prevent="handleDonate()">
          <textarea type="text" src="" alt="" v-model="editable" rows="4" />
          <button type="submit">donate</button>
        </form>
      </div>
      <div>
        <ul>
          <li v-for="s in supa">
            <div>{{s}}</div>
          </li>
        </ul>
      </div>
    </div> -->
  </div>
</template>

<script>
import { computed } from "@vue/reactivity";
import { onMounted, ref, watchEffect } from "vue";
import { AppState } from "../AppState.js";
import DonateForm from "../components/DonateForm.vue";
import { firesService } from "../services/FireBaseService.js";
import { supabaseService } from "../services/SupabaseService";
import { logger } from "../utils/Logger.js";
import Pop from "../utils/Pop.js";

export default {
    props: {},
    setup(props) {
        const editable = ref("");
        onMounted(() => {
            getChats();
        });
        watchEffect(() => { });
        async function getChats() {
            await supabaseService.getChats();
        }
        return {
            editable,
            supa: computed(() => AppState.supabase),
            async handleDonate() {
                try {
                    // console.log(editable.value);
                    // await firesService.addChat(editable.value);
                    const res = await supabaseService.addSupabaseChat(editable.value);
                }
                catch (error) {
                    console.error("[]", error);
                    Pop.error(error);
                }
            },
        };
    },
    components: { DonateForm }
};
</script>

<style lang="scss" scoped>

.heroImg{
  background-image: url(https://images.unsplash.com/photo-1614338577234-8747c0b37571?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1769&q=80);
  height: 400px;
  width: 100vw;
background-size: cover;
  background-position: center;
  background-attachment: fixed;
  border-radius: 4px;

}
</style>
