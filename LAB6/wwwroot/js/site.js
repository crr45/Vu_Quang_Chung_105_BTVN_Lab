// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function filterPrice() {
    const min = document.getElementById("min-price").value;
    const max = document.getElementById("max-price").value;
    fetchProduct({ minPrice: min, maxPrice: max });
}

function filterFreeShipping() {
    const isFree = document.getElementById("freeShipping").checked;
    fetchProduct({ isFreeShipping: isFree });
}

function fetchProduct(filters) {
    let apiUrl = `@Url.Content("~/")Product/Filters?`;
    for (const key in filters) {
        if (filters[key] !== undefined && filters[key] !== '') {
            apiUrl += `${key}=${encodeURIComponent(filters[key])}&`;
        }
    }

    apiUrl = apiUrl.replace(/&$/, "");
    fetch(apiUrl)
        .then((res) => res.json())
        .then((data) => {
            let products = data.products;
            let total = data.total;
            let listProduct = document.getElementById("list-product");
            let content = "";

            products.forEach(product => {
                content += `<div class="col-md-3 mb-3">
                    <div class="card">
                        <img src="${product.imageUrl}" class="img-fluid rounded" alt="${product.name}" />
                        <div class="card-body">
                            <h6>${product.name}</h6>
                            <div class="d-flex flex-row align-items-center mb-1">
                                <h4 class="mb-1 me-1">$${product.salePrice}</h4>
                                <span class="text-danger"><s>$${product.originalPrice}</s></span>
                            </div>
                            <h6 class="${product.isFreeShipping ? 'text-success' : 'text-danger'}">
                                ${product.isFreeShipping ? 'Free' : 'Paid'} shipping
                            </h6>
                            <button class="btn btn-primary shadow-0" type="button">Buy this</button>
                        </div>
                    </div>
                </div>`;
            });

            listProduct.innerHTML = content;
            document.getElementById("count-product").innerText = `${total} Items found`;

            // Tạo phân trang
            let pageSize = 8;
            let pageCount = Math.ceil(total / pageSize);
            let pagination = document.getElementById("pagination");
            pagination.innerHTML = "";
            for (let i = 1; i <= pageCount; i++) {
                pagination.innerHTML += `<li class="page-item"><a class="page-link" href="#" onclick="goToPage(${i})">${i}</a></li>`;
            }
        });
}

function goToPage(pageNumber) {
    fetchProduct({ page: pageNumber });
}


