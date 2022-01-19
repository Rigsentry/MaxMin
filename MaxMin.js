/*Date: 01/19/2022
Cuong phan */
function maxMin(k, arr) {
    //Sort the array in ascending order take O(nlogn)
    var sortedArray = arr.sort(function(a, b){return a - b});
    //Slice up to index k
    var subArray = sortedArray.slice(0,k);
    //Find min and max and calculate the distance take O(n)
    var result = findDistanceMaxMin(subArray);
    return result;
}
function findDistanceMaxMin(arr) {
    var max = Number.MIN_VALUE;
    var min = Number.MAX_VALUE;
    for (var i=0; i<arr.length; i++) {
        if(arr[i] > max) {
            max = arr[i];
        }
        if(arr[i] < min) {
            min = arr[i];
        }
    }
    return max - min; 
}
/**Test cases **/
var arr1 = [1, 4, 7, 2];
var k1 = 2;
console.log(maxMin(k1, arr1));
var arr2 = [1,2,3,4,10,20,30,40,100,200];
var k2 = 4;
console.log(maxMin(k2, arr2));