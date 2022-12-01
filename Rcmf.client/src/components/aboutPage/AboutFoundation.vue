<template>
  <div class="container">
    <div class="row">
      <div class="col-md-12 p-4">
        <img
          src="http://ourfallenbrother.org/pictures/memorial.jpg"
          alt="Coos Bay FireFighters Memorial"
          class="coosbay elevation-5 rounded"
        />
      </div>
    </div>
  </div>
</template>

<script>
import { computed } from "@vue/reactivity";
import { onMounted, ref, watchEffect } from "vue";

export default {
  props: {},
  setup(props) {
    const editable = ref({});

    onMounted(() => {});
    watchEffect(() => {});

    return {
      editable,
    };
  },
};
</script>

<style lang="scss" scoped></style>
