<template>
    <div class="spin"></div>
</template>

<script lang="ts">
import { defineComponent } from 'vue';

export default defineComponent({
  name: 'SpinnerComponent',
})
</script>

<style>
.spin {
  display: block;
  width: 40px;
  height: 40px;
  margin: 30px auto;
  border: 3px solid transparent;
  border-radius: 50%;
  border-top-color: #ff8800;
  animation: spin 1s ease infinite;
}

@keyframes spin {
  to { -webkit-transform: rotateZ(360deg);  }
}
</style>
