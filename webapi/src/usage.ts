import { Fetcher } from "openapi-typescript-fetch"

import { paths } from "./ApiProxy"

export const fetcher = Fetcher.for<paths>()

const getUsers = fetcher.path("/api/UserDatabase").method("get").create()

const user = await getUsers({})
console.log(user.data[0].email)
