#!/bin/sh
cat <<EOF > /usr/share/nginx/html/scripts/env.js
window.API_ENDPOINT="$API_ENDPOINT";
EOF

nginx -g "daemon off;"