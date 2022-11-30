<template>
  <div class="container">
    <div class="row">
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
    </div>
  </div>
</template>

<script>
import { computed } from "@vue/reactivity";
import { onMounted, ref, watchEffect } from "vue";
import { AppState } from "../AppState.js";
import { firesService } from "../services/FireBaseService.js";
import { supabaseService } from "../services/SupabaseService";
import { logger } from "../utils/Logger.js";
import Pop from "../utils/Pop.js";

export default {
  props: {},
  setup(props) {
    const editable = ref("");

    onMounted(() => {
    getChats()
    });
    watchEffect(() => {});

    async function getChats(){
      await supabaseService.getChats()
    }

    return {
      editable,
      supa: computed(() => AppState.supabase),
      async handleDonate() {
        try {
          // console.log(editable.value);
          // await firesService.addChat(editable.value);
          const res = await supabaseService.addSupabaseChat(editable.value)
        } catch (error) {
          console.error("[]", error);
          Pop.error(error);
        }
      },
    };
  },
};
</script>

<style lang="scss" scoped></style>
