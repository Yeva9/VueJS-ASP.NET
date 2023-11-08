<template>
  <div class="text-center">
    <h1>{{ header }}</h1>
  </div>
</template>

<script lang="ts">
import { defineComponent } from 'vue';

export default defineComponent({
  name: 'AboutView',
  setup() {
    var header = "This is an about page";

    return { header }
  }
})
</script>

<style>
</style>
