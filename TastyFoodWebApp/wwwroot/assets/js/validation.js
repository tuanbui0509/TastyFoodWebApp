// Đối tượng validator
function Validator(options) {

    function getParent(element, selector) {
        while (element.parentElement) {
            if (element.parentElement.matches(selector))
                return element.parentElement
        }
        element = element.parentElement;
    }

    let selectorRules = {}

    // Hàm thực hiện validate
    function validate(inputElement, rule) {
        let errorElement = getParent(inputElement, options.formGroupSelector).querySelector(options.errorSelector)
        let errorMassage = rule.test(inputElement.value)

        // Lấy rules của selectorRules
        rules = selectorRules[rule.selector]
        // lặp qua mỗi rules
        for (let i = 0; i < rules.length; i++) {
            errorMassage = rules[i](inputElement.value);
            if (errorMassage) {
                break
            }
        }

        if (errorMassage) {
            errorElement.innerText = errorMassage
            getParent(inputElement, options.formGroupSelector).classList.add('invalid')
        }
        else {
            errorElement.innerText = ''
            getParent(inputElement, options.formGroupSelector).classList.remove('invalid')
        }

        return !errorMassage
    }
    // Lấy element của form cần validate
    let formElement = document.querySelector(options.form);
    if (formElement) {
        // Lặp qua mỗi rule và validate
        formElement.onsubmit = function (e) {
            e.preventDefault()
            let isFormValid = true;
            options.rules.forEach(function (rule) {
                let inputElement = formElement.querySelector(rule.selector)
                let isValid = validate(inputElement, rule)
                if (!isValid) {
                    isFormValid = false
                }
            })


            if (isFormValid) {
                // Submit with javascript
                if (typeof (options.onSubmit) === 'function') {
                    let enableInputs = formElement.querySelectorAll('[name]:not([disabled])')
                    let formValues = Array.from(enableInputs).reduce(function (values, input) {
                        values[input.name] = input.value
                        return values
                    }, {})
                    options.onSubmit(formValues)
                }
            }
            // Submit with default
            else {
                // formElement.submit()
            }
        }

        // Lặp qua mỗi rule và xử lý (lắng nghe sự kiện blur, input,...)
        options.rules.forEach(function (rule) {
            // Lưu lại các rules cho mỗi input
            // console.log(selectorRules[rule.selector]);
            if (Array.isArray(selectorRules[rule.selector])) {
                selectorRules[rule.selector].push(rule.test)
            } else
                selectorRules[rule.selector] = [rule.test]

            let inputElement = formElement.querySelector(rule.selector)
            let errorElement = getParent(inputElement, options.formGroupSelector).querySelector(options.errorSelector)
            if (inputElement) {
                // Xử lý trường hợp blur khòi input
                inputElement.onblur = function () {
                    validate(inputElement, rule)
                }
                // Xử lý người dùng nhập vào input
                inputElement.oninput = function () {
                    errorElement.innerText = ''
                    getParent(inputElement, options.formGroupSelector).classList.remove('invalid')
                }
            }
        })
    }

    console.log(selectorRules);
}

// Định nghĩa rules
// Nguyên tắc của rule:
// 1. Khi có lỗi => Trả ra message lỗi
// 2. Khi hợp lệ => Không trả ra gì undefined
Validator.isRequired = function (selector, message) {
    return {
        selector,
        test: function (value) {
            return value.trim() ? undefined : message
        }
    };
}

Validator.isEmail = function (selector, message) {
    return {
        selector,
        test: function (value) {
            let regex = /^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/
            return regex.test(value.trim()) ? undefined : message 
        }
    };
}

Validator.minLength = function (selector, minLength, message) {
    return {
        selector,
        test: function (value) {
            return value.length >= minLength ? undefined : message 
        }
    }
}

Validator.isConfirmed = function (selector, getConfirmValue, message) {
    return {
        selector,
        test: function (value) {
            return value === getConfirmValue() ? undefined : message
        }

    }
}