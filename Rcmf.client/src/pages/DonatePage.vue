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
    </div>
  </div>
</template>

<script>
import { computed } from "@vue/reactivity";
import { onMounted, ref, watchEffect } from "vue";
import { AppState } from "../AppState.js";
import { firesService } from "../services/FireBaseService.js";
import { logger } from "../utils/Logger.js";
import Pop from "../utils/Pop.js";

export default {
  props: {},
  setup(props) {
    const editable = ref("");

    onMounted(() => {});
    watchEffect(() => {});

    return {
      editable,
      async handleDonate() {
        try {
          console.log(editable.value);
          await firesService.addChat(editable.value);
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
