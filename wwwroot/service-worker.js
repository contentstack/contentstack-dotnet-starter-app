
// In development, always fetch from the network and do not enable offline support.
// This is because caching would make development more difficult (changes would not
// be reflected on the first load after each change).
self.addEventListener('fetch', event => event.respondWith(onFetch(event)));

//async function onFetch(event) {
//    let cachedResponse = null;
//    if (event.request.method === 'GET') {
//        // For all navigation requests, try to serve index.html from cache
//        // If you need some URLs to be server-rendered, edit the following check to exclude those URLs
//        const shouldServeIndexHtml = event.request.mode === 'navigate';

//        const request = shouldServeIndexHtml ? 'index.html' : event.request;
//        const cache = await caches.open(cacheName);
//        cachedResponse = await cache.match(request);
//    }

//    return cachedResponse || fetch(event.request);
//}
