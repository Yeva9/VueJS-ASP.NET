<template>
  <div class="text-center">
    <h1>job detailes</h1>
    <p>the job id is {{ id }}</p>
  </div>
</template>

<script lang="ts">
import { defineComponent } from 'vue';

export default defineComponent({
  name: 'JobDetailes',
  props: ['id'],
})
</script>

<style>
</style>