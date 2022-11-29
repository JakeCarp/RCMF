<template>
 <div class="container">
   <div class="row">
     <div class="col-md-12">
       ADMIN PAGE
     </div>
   </div>
 </div>
</template>

<script>
import { computed } from 'vue'
import { AppState } from '../AppState'
export default {
  setup() {
    return {
      account: computed(() => AppState.account)
    }
  }
}
</script>

<style scoped>
img {
  max-width: 100px;
}
</style>
