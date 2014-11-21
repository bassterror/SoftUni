function findMinAndMax(nums) {
    var min = Math.min.apply(null, nums);
    var max = Math.max.apply(null, nums);

    console.log('Min -> ' + min);
    console.log('Max -> ' + max);
}